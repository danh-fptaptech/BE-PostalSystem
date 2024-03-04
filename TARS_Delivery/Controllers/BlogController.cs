using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogRepository _blogRepository;
        
        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogs()
        {
            try
            {
                var blogs = await _blogRepository.GetAllBlogs();
                return Ok(blogs);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogById(int id)
        {
            try
            {
                var blog = await _blogRepository.GetBlogById(id);
                return Ok(blog);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("employee/{id}")]
        public async Task<IActionResult> GetBlogByEmployeeId(int id)
        {
            try
            {
                var blog = await _blogRepository.GetBlogByEmployeeId(id);
                return Ok(blog);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog([FromBody] Blog blog)
        {
            try
            {
                var newBlog = await _blogRepository.CreateBlog(blog);
                return Ok(newBlog);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBlog(int id, [FromBody] Blog blog)
        {
            try
            {
                var updatedBlog = await _blogRepository.UpdateBlog(id, blog);
                return Ok(updatedBlog);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            try
            {
                var deletedBlog = await _blogRepository.DeleteBlog(id);
                return Ok(deletedBlog);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
