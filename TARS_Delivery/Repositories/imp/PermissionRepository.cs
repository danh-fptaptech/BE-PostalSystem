using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly DatabaseContext _context;
        public PermissionRepository(DatabaseContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Permission>> GetPermissions()
        {
            return await _context.Permissions.ToListAsync();
        }

        public async Task<Permission> GetPermission(string permissionName)
        {
            return await _context.Permissions.FirstOrDefaultAsync(p => p.PermissionName == permissionName);

        }

        public async Task<Permission> Create(Permission permission)
        {
            try
            {
                var duplicatedName = await _context.Permissions.
                    FirstOrDefaultAsync(p => p.PermissionName == permission.PermissionName);
                if (duplicatedName != null)
                {
                    throw new Exception("The permission name has already existed.");
                }

                await _context.Permissions.AddAsync(permission);
                await _context.SaveChangesAsync();

                return permission;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Permission> Update(string permissionName, RDTOPermission permission)
        {
            try
            {
                var updatedPermission = await _context.Permissions.FirstOrDefaultAsync(p => p.PermissionName == permissionName);
                if (updatedPermission != null)
                {
                    var existingPermission = await _context.Permissions
                        .FirstOrDefaultAsync(p => p.PermissionName == permission.name && p.Id != updatedPermission.Id);

                    if (existingPermission != null)
                    {
                        throw new Exception("The permission name already exists.");
                    }

                    _context.Entry(updatedPermission).CurrentValues.SetValues(permission);
                    await _context.SaveChangesAsync();

                    return updatedPermission;
                }
                throw new Exception("This permission does not exist!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Permission>> GetPermissionsByName(IEnumerable<string> permissionNames)
        {
            return await _context.Permissions.Where(p => permissionNames.Contains(p.PermissionName)).ToListAsync();
        }
    }
}
