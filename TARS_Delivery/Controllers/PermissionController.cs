
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services.imp;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly PermissionService _service;
        public PermissionController(PermissionService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<ActionResult> GetPermissions()
        {
            try
            {
                var permissions = await _service.GetPermissions();
                return Ok(permissions);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> GetPermission(int id)
        {
            try
            {
                Permission permission = await _service.GetPermission(id);
                if (permission != null)
                {
                    return Ok(permission);
                }
                return NotFound("This permissions does not exist !");
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpPost]
        public async Task<ActionResult> CreatePermission([FromForm] Permission permission)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _service.Create(permission);
                    return Ok(permission);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PermissionName", ex.Message);
                return Problem(ex.Message);
            }
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePermission(int id, [FromForm] Permission permission)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _service.Update(id, permission);
                    return Ok(permission);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> RemovePermission(int id)
        {
            try
            {
                Permission permission = await _service.GetPermission(id);
                if (permission != null)
                {
                    await _service.Delete(id);
                    return Ok("Delete Successfully.");
                }
                return NotFound("This permission does not exist !");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
