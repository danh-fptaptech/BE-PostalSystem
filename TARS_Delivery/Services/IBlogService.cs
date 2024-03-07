using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services
{
    public interface IBlogService
    {
        public Task<List<RDTOBlog>> GetAllBlogs();
        public Task<Blog> GetBlogById(int id);
        public Task<List<RDTOBlog>> GetBlogByEmployeeId(int id);
        public Task<Blog> CreateBlog(RDTOBlog blog);
        public Task<Blog> UpdateBlog(int id, RDTOBlog blog);
        public Task<Blog> DeleteBlog(int id);
    }
}
