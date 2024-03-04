using AutoMapper;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp
{
    public class BlogService
    {
        private readonly IBlogRepository _rp;
        private readonly IMapper _mapper;

        public BlogService(IBlogRepository blogRepository, IMapper mapper)
        {
            _rp = blogRepository;
            _mapper = mapper;
        }
        
        public async Task<ICollection<Blog>> GetAllBlogs()
        {
            ICollection<Blog> blogs = await _rp.GetAllBlogs();
            return blogs;
        }

        public async Task<Blog> GetBlogById(int id)
        {
            return await _rp.GetBlogById(id);
        }

        public async Task<Blog> AddBlog(Blog blog)
        {
            Blog newBlog = new()
            {
                Title = blog.Title,
                Slug = blog.Slug,
                Content = blog.Content,
                Author = blog.Author,
                EmployeeID = blog.EmployeeID,
                Status = EStatusData.Active,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            return await _rp.CreateBlog(newBlog);
        }

        public async Task<Blog> UpdateBlog(int id, Blog blog)
        {
            return await _rp.UpdateBlog(id, blog);
        }

        public async Task<Blog> DeleteBlog(int id)
        {
            return await _rp.DeleteBlog(id);
        }
        
    }
}
