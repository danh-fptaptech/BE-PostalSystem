using AutoMapper;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _rp;
        private readonly IMapper _mapper;

        public BlogService(IBlogRepository blogRepository, IMapper mapper)
        {
            _rp = blogRepository;
            _mapper = mapper;
        }
        
        public async Task<List<RDTOBlog>> GetAllBlogs()
        {
            return await _rp.GetAllBlogs();
        }

        public async Task<Blog> GetBlogById(int id)
        {
            return await _rp.GetBlogById(id);
        }

        public async Task<List<RDTOBlog>> GetBlogByEmployeeId(int id)
        {
            return await _rp.GetBlogByEmployeeId(id);
        }

        public async Task<Blog> CreateBlog(RDTOBlog blog)
        {
            return await _rp.CreateBlog(blog);
        }

        public async Task<Blog> UpdateBlog(int id, RDTOBlog blog)
        {
            return await _rp.UpdateBlog(id, blog);
        }

        public async Task<Blog> DeleteBlog(int id)
        {
            return await _rp.DeleteBlog(id);
        }
    }
}
