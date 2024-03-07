
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services;
using TARS_Delivery.Services.imp;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IPermissionService _permissionService;

        public RoleController(IRoleService roleService, IPermissionService permissionService)
        {
            _roleService = roleService;
            _permissionService = permissionService;
        }


        // GET: api/Roles/{roleId} => done
        [HttpGet("{id}")] 
        public async Task<ActionResult> GetRole(int id)
        {
            try
            {
                var role = await _roleService.GetRole(id);
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

        // POST: api/Roles => done
        [HttpPost] 
        public async Task<ActionResult> CreateRole([FromBody] RDTORole role)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _roleService.Create(role);
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

        // PUT: api/Roles/{roleId} => done
        [HttpPut("{id}")] 
        public async Task<ActionResult> UpdateRole(int id, [FromBody] RDTORole role)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var updatedRole = await _roleService.GetRole(id);
                    if (updatedRole != null)
                    {
                        if(updatedRole.Id > 3)
                        {
                            await _roleService.Update(id, role);
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

        // DELETE: api/Roles/{roleId} => done
        [HttpDelete("{id}")] 
        public async Task<ActionResult> DeleteRole(int id)
        {
            try
            {
                var removedRole = await _roleService.GetRole(id);
                if(removedRole != null)
                {
                    if(removedRole.Id > 4)
                    {
                        await _roleService.Delete(id);
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            IEnumerable<Role> roles = await _roleService.GetRoles();
            return Ok(roles);
        }

        [HttpGet("Permissions")]
        public async Task<ActionResult<IEnumerable<SDTORole>>> GetRolesWithPermissions()
        {
            IEnumerable<SDTORole> roles = await _roleService.GetRolesWithPermissions();
            return Ok(roles);
        }

        [HttpGet("{id}/Permissions")]
        public async Task<ActionResult<SDTORole>> GetRoleWithPermissions(int id)
        {
            SDTORole roleWithPermission = await _roleService.GetRoleWithPermissions(id);
            return Ok(roleWithPermission);
        }

        [HttpPost("{roleId}/Permission")]
        public async Task<ActionResult<RoleHasPermission>> AddPermissionToRole(
            int roleId, [FromBody] RDTOPermissionNames permissionNames)
        {
            try
            {
                // Are role and permission valid ? 
                var existRole = await _roleService.GetRoleWithPermissions(roleId);
                var existPermissions = await _permissionService.GetPermissionsByName(permissionNames.PermissionNames);
                if (existRole == null || existPermissions.Count() == 0)
                {
                    return NotFound("The role or the permission doesn't exist !");
                }
                foreach(var permission in existRole.RoleHasPermissions)
                {
                    foreach (var permissionName in permissionNames.PermissionNames)
                    {
                        if (permission == permissionName)
                        {
                            return Conflict("Permission already assigned to role.");
                        }
                    }
                }

                var role = await _roleService.AddPermission(roleId, permissionNames.PermissionNames);

                return Ok(role);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
                throw;
            }

        }

        // DELETE: api/Roles/{roleId}/Permissions/{permissionId} => done
        [HttpDelete("{roleId}/Permission/{permissionName}")]
        public async Task<IActionResult> RemovePermissionFromRole(int roleId, string permissionName)
        {
            try
            {
                var existRole = await _roleService.GetRole(roleId);
                var existPermission = await _permissionService.GetPermission(permissionName);
                if (existRole == null || existPermission == null)
                {
                    return NotFound("The role or the permission doesn't exist !");
                }

                await _roleService.DeletePermission(roleId, permissionName);

                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }

    }
}
