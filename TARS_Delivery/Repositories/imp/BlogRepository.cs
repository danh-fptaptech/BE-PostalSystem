using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
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
        
        public async Task<List<Blog>> GetAllBlogs()
        {
            return await _db.Blogs.ToListAsync();
        }
        
        public async Task<Blog> GetBlogById(int id)
        {
            return await _db.Blogs.FirstOrDefaultAsync(b=>b.Id == id);
        }
        
        public async Task<Blog> GetBlogByEmployeeId(int id)
        {
            return await _db.Blogs.FirstOrDefaultAsync(b=>b.EmployeeID == id);
        }
        
        public async Task<Blog> CreateBlog(Blog blog)
        {
            try
            {
                await _db.Blogs.AddAsync(blog);
                await _db.SaveChangesAsync();
                return blog;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Error while adding blog");
            }
        }
        
        public async Task<Blog> UpdateBlog(int id, Blog blog)
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
                blogToUpdate.EmployeeID = blog.EmployeeID;
                blogToUpdate.UpdatedAt = DateTime.Now;
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
