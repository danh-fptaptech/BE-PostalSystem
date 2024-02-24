using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleHasPermissionController : ControllerBase
    {
        private readonly DatabaseContext _context;
        public RoleHasPermissionController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Roles/Permissions => done
      /*  [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> GetRolesWithPermission()
        {
            IEnumerable<Role> roles = await _context.Roles.Include(r => r.RoleHasPermissions).ToListAsync();
            return Ok(roles);
        }

        // POST: api/Roles/{roleId}/Permissions/{permissionId} => done
        [HttpPost("{roleId}/Permissions/{permissionId}")]
        public async Task<ActionResult<RoleHasPermission>> AddPermissionToRole(int roleId, int permissionId)
        {
            try
            {
                // Are role and permission valid ? 
                var existRole = await _context.Roles.AnyAsync(r => r.Id == roleId);
                var existPermission = await _context.Permissions.AnyAsync(p => p.Id == permissionId);
                if (!existRole || !existPermission)
                {
                    return NotFound("The role or the permission doesn't exist !");
                }
                else
                {
                    // Thêm mới
                    var roleHasPermission = new RoleHasPermission
                    {
                        RoleId = roleId,
                        PermissionId = permissionId
                    };

                    // Kiểm tra trùng lặp
                    var existingRoleHasPermission = await _context.RoleHasPermissions
                        .AnyAsync(rhp => rhp.RoleId == roleId && rhp.PermissionId == permissionId);

                    if (existingRoleHasPermission)
                    {
                        return Conflict("Permission already assigned to role.");
                    }

                    await _context.RoleHasPermissions.AddAsync(roleHasPermission);
                    await _context.SaveChangesAsync();
                    return Ok(roleHasPermission);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
                throw;
            }

        }

        // DELETE: api/Roles/{roleId}/Permissions/{permissionId} => done
        [HttpDelete("{roleId}/Permissions/{permissionId}")]
        public async Task<ActionResult<RoleHasPermission>> RemovePermissionFromRole(int roleId, int permissionId)
        {
            try
            {
                var roleHasPermission = await _context.RoleHasPermissions.FindAsync(roleId, permissionId);
                if(roleHasPermission != null)
                {
                    _context.RoleHasPermissions.Remove(roleHasPermission);
                    await _context.SaveChangesAsync();
                    return Ok("Remove permission from role successfully.");
                }
                return NotFound("The role is invalid !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
*/
    }
}
