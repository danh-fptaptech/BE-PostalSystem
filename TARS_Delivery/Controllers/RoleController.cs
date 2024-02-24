using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security;
using TARS_Delivery.Models.DTOs;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services.imp;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleService service;
        private readonly IMapper mapper;
        public RoleController(RoleService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult> GetRoles()
        {
            try
            {
                var roles = await service.GetRoles();
                return Ok(roles);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> GetRole(int id)
        {
            try
            {
                var role = await service.GetRole(id);
                if (role != null)
                {
                    return Ok(role);
                }
                return NotFound("This role does not exist !");
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpPost]
        public async Task<ActionResult> CreateRole(Role RolePost)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await service.Create(RolePost);
                    return Ok(RolePost);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("RoleName", ex.Message);
                return Problem(ex.Message);
            }
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateRole(int id, Role role)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var updatedRole = await service.GetRole(id);
                    if(updatedRole != null)
                    {
                        updatedRole.RoleHasPermissions = role.RoleHasPermissions;
                        updatedRole.Status = role.Status;
                        return Ok(updatedRole);
                    }
                    return NotFound("This role does not exist !");
                }
                return BadRequest();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
