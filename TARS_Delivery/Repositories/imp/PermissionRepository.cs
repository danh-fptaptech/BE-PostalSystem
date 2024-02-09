using Microsoft.EntityFrameworkCore;
using System.Data;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly DatabaseContext _context;
        public PermissionRepository(DatabaseContext databaseContext)
        {
            _context = databaseContext;
        }


        public async Task<IEnumerable<Permission>> GetPermissions()
        {
            return await _context.Permissions.ToListAsync();
        }

        public async Task<Permission> GetPermission(int id)
        {
            return await _context.Permissions.FindAsync(id);
        }

        public async Task<Permission> Create(Permission permission)
        {
            try
            {
                var duplicatedName = await _context.Permissions.FirstOrDefaultAsync(p => p.PermissionName == permission.PermissionName);
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

        public async Task<Permission> Update(int id, RDTOPermisson permission)
        {
            try
            {
                var updatedPermission = await _context.Permissions.FindAsync(id);
                if (updatedPermission != null)
                {
                    updatedPermission.PermissionName = permission.PermissionName;
                    await _context.SaveChangesAsync();
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Permission> Delete(int id)
        {
            try
            {
                var existedPermission = await _context.Permissions.FindAsync(id);
                if (existedPermission != null)
                {
                    _context.Permissions.Remove(existedPermission);
                    await _context.SaveChangesAsync();
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
