
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services.imp;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleService _service;
        public RoleController(RoleService service)
        {
            _service = service;
        }

        [HttpGet] // done
        public async Task<ActionResult> GetRoles()
        {
            try
            {
                var roles = await _service.GetRoles();
                return Ok(roles);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("{id}")] // done
        public async Task<ActionResult> GetRole(int id)
        {
            try
            {
                var role = await _service.GetRole(id);
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

        [HttpPost] // done
        public async Task<ActionResult> CreateRole([FromForm] RDTORole role)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _service.Create(role);
                    return Ok(role);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("RoleName", ex.Message);
                return Problem(ex.Message);
            }
        }

        [HttpPut("{id}")] // done
        public async Task<ActionResult> UpdateRole(int id, [FromForm] RDTORole role)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var updatedRole = await _service.GetRole(id);
                    if (updatedRole != null)
                    {
                        if(updatedRole.Id > 3)
                        {
                            await _service.Update(id, role);
                            return Ok(updatedRole);
                        }
                        return Content("It's system role. You can not edit it.");
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

        [HttpDelete("{id}")] // done
        public async Task<ActionResult> DeleteRole(int id)
        {
            try
            {
                var removedRole = await _service.GetRole(id);
                if(removedRole != null)
                {
                    if(removedRole.Id > 3)
                    {
                        await _service.Delete(id);
                        return Ok("Delete role successfully.");
                    }
                    return Content("It's system role. You can not delete.");
                }
                return NotFound("This role does not exist !");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
