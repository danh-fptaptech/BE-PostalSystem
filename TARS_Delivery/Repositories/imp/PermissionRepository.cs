using Microsoft.EntityFrameworkCore;
using System.Data;
using TARS_Delivery.Models;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly DatabaseContext databaseContext;
        public PermissionRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }


        public async Task<IEnumerable<Permission>> GetPermissions()
        {
            return await databaseContext.Permissions.ToListAsync();
        }

        public async Task<Permission> GetPermission(int id)
        {
            var permission = await databaseContext.Permissions.FindAsync(id);
            if (permission != null)
            {
                return permission;
            }
            return null;
        }


        public async Task<Permission> Create(Permission permission)
        {
            var duplicatedName = await databaseContext.Permissions.FirstOrDefaultAsync(p => p.PermissionName == permission.PermissionName);
            if (duplicatedName != null)
            {
                throw new InvalidOperationException("Permission name already exists.");
            }

            await databaseContext.Permissions.AddAsync(permission);
            await databaseContext.SaveChangesAsync();

            return permission;
        }


        public async Task<Permission> Remove(int id)
        {
            var existedPermission = await databaseContext.Permissions.FindAsync(id);
            if (existedPermission != null)
            {
                databaseContext.Permissions.Remove(existedPermission);
                await databaseContext.SaveChangesAsync();
            }
            return null;
        }
    }
}
