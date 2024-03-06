using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<List<Blog>>> GetAllBlogs()
        {
            try
            {
                return Ok(await _blogService.GetAllBlogs());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public async Task<ActionResult<Blog>> GetBlogById(int id)
        {
            Blog blog = await _blogService.GetBlogById(id);
            if (blog == null)
            {
                return NotFound();
            }
            return Ok(blog);
        }

        [HttpGet]
        [Route("getBlogByEmployeeId/{id}")]
        public async Task<ActionResult<List<RDTOBlog>>> GetBlogByEmployeeId(int id)
        {
            try
            {
                return Ok(await _blogService.GetBlogByEmployeeId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Blog>> AddBlog(RDTOBlog blog)
        {
            try
            {
                Blog newBlog = await _blogService.CreateBlog(blog);
                return Created($"/api/blog/{newBlog.Id}", newBlog);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("update/{id}")]
        public async Task<ActionResult<Blog>> UpdateBlog(int id, RDTOBlog blog)
        {
            try
            {
                Blog updatedBlog = await _blogService.UpdateBlog(id, blog);
                return Ok(updatedBlog);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<ActionResult<Blog>> DeleteBlog(int id)
        {
            try
            {
                Blog deletedBlog = await _blogService.DeleteBlog(id);
                return Ok(deletedBlog);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
