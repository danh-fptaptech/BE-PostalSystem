
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services;
using TARS_Delivery.Services.imp;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _service;
        public PermissionController(IPermissionService service)
        {
            _service = service;
        }

        // GET: api/Permissions => done
        [HttpGet]
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

        // GET: api/Permissions/{permissionId} => done
        [HttpGet("{permissionName}")]
        public async Task<ActionResult> GetPermission(string permissionName)
        {
            try
            {
                Permission permission = await _service.GetPermission(permissionName);
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

        // POST: api/Permissions/permission => done
        [HttpPost]
        public async Task<ActionResult> CreatePermission([FromBody] RDTOPermission permission)
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

        // PUT: api/Permissions/{permissionId} => done
        [HttpPut("{permissionName}")]
        public async Task<ActionResult> UpdatePermission(string permissionName, [FromBody] RDTOPermission permission)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Permission updatedPermission = await _service.GetPermission(permissionName);
                    if(updatedPermission != null)
                    {
                        await _service.Update(permissionName, permission);
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
