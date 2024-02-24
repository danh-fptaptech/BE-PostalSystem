using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services.imp;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly PermissionService service;
        private readonly IMapper mapper;

        public PermissionController(PermissionService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult> GetPermissions()
        {
            try
            {
                var permissions = await service.GetPermissions();
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
                Permission permission = await service.GetPermission(id);
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
        public async Task<ActionResult> CreatePermission(Permission permission)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await service.Create(permission);
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


        [HttpDelete("{id}")]
        public async Task<ActionResult> RemovePermission(int id)
        {
            try
            {
                Permission permission = await service.GetPermission(id);
                if (permission != null)
                {
                    await service.Remove(id);
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
