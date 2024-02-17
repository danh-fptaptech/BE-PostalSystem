
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req;
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


        [HttpGet] // done
        public async Task<ActionResult> GetPermissions()
        {
            try
            {
                var permissions = await _service.GetPermissions();
                return Ok(permissions);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }


        [HttpGet("{id}")] // done
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
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }


        [HttpPost] // done
        public async Task<ActionResult> CreatePermission([FromForm] RDTOPermission permission)
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


        [HttpPut("{id}")] // done
        public async Task<ActionResult> UpdatePermission(int id, [FromForm] RDTOPermission permission)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Permission updatedPermission = await _service.GetPermission(id);
                    if(updatedPermission != null)
                    {
                        await _service.Update(id, permission);
                        return Ok(permission);
                    }
                    return NotFound("This permission does not exist !");
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
