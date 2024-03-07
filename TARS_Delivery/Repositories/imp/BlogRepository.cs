using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp
{
    public class BlogRepository : IBlogRepository
    {
        private readonly DatabaseContext _db;
        
        public BlogRepository(DatabaseContext db, IMapper mapper)
        {
            _db = db;
        }
        
        public async Task<List<RDTOBlog>> GetAllBlogs()
        {
            return await _db.Blogs.Select(b=>new RDTOBlog
            {
                Id = b.Id,
                Title = b.Title,
                Slug = b.Slug,
                Content = b.Content,
                Author = b.Author,
                EmployeeId = b.EmployeeId,
                Category = b.Category,
                CreatedAt = b.CreatedAt,
                UpdatedAt = b.UpdatedAt,
                Status = b.Status
            }).ToListAsync();
        }
        
        public async Task<Blog> GetBlogById(int id)
        {
            return await _db.Blogs.Include(b=>b.Employee).FirstOrDefaultAsync(b=>b.Id == id);
        }
        
        public async Task<List<RDTOBlog>> GetBlogByEmployeeId(int id)
        {
            return await _db.Blogs.Where(b=>b.EmployeeId == id).Select(b=>new RDTOBlog
            {
                Id = b.Id,
                Title = b.Title,
                Slug = b.Slug,
                Content = b.Content,
                Author = b.Author,
                EmployeeId = b.EmployeeId,
                CreatedAt = b.CreatedAt,
                UpdatedAt = b.UpdatedAt,
                Status = b.Status
            }).ToListAsync();
        }
        
        public async Task<Blog> CreateBlog(RDTOBlog blog)
        {
            try
            {
                Blog newBlog = new Blog
                {
                    Title = blog.Title,
                    Slug = blog.Slug,
                    Content = blog.Content,
                    Author = blog.Author,
                    EmployeeId = blog.EmployeeId,
                    Category = blog.Category,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = blog.Status
                };
                _db.Blogs.Add(newBlog);
                await _db.SaveChangesAsync();
                return newBlog;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Error while creating blog");
            }
        }
        
        public async Task<Blog> UpdateBlog(int id, RDTOBlog blog)
        {
            try
            {
                Blog blogToUpdate = _db.Blogs.Find(id);
                if (blogToUpdate == null)
                {
                    throw new Exception("Blog not found");
                }
                blogToUpdate.Title = blog.Title;
                blogToUpdate.Slug = blog.Slug;
                blogToUpdate.Content = blog.Content;
                blogToUpdate.Author = blog.Author;
                blogToUpdate.EmployeeId = blog.EmployeeId;
                blogToUpdate.UpdatedAt = DateTime.Now;
                blogToUpdate.Status = blog.Status;
                await _db.SaveChangesAsync();
                return blogToUpdate;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Error while updating blog");
            }
        }
        
        public async Task<Blog> DeleteBlog(int id)
        {
            try
            {
                Blog blogToDelete = _db.Blogs.Find(id);
                if (blogToDelete == null)
                {
                    throw new Exception("Blog not found");
                }
                _db.Blogs.Remove(blogToDelete);
                await _db.SaveChangesAsync();
                return blogToDelete;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Error while deleting blog");
            }
        }
    }
}
