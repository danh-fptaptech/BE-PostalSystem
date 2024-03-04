using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories
{
    public interface IBlogRepository
    {
        public Task<List<Blog>> GetAllBlogs();
        public Task<Blog> GetBlogById(int id);
        public Task<Blog> GetBlogByEmployeeId(int id);
        public Task<Blog> CreateBlog(Blog blog);
        public Task<Blog> UpdateBlog(int id,Blog blog);
        public Task<Blog> DeleteBlog(int id);
    }
}
