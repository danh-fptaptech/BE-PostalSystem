using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository repository;
        public PermissionService(IPermissionRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Permission>> GetPermissions()
        {
            return await repository.GetPermissions();
        }

        public async Task<Permission> GetPermission(int id)
        {
            return await repository.GetPermission(id);
        }

        public async Task<Permission> Create(Permission permission)
        {
            return await repository.Create(permission);
        }

        public async Task<Permission> Remove(int id)
        {
            return await repository.Remove(id);
        }
    }
}
