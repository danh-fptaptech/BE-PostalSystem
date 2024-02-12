
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _repository;
        public PermissionService(IPermissionRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Permission>> GetPermissions()
        {
            return await _repository.GetPermissions();
        }

        public async Task<Permission> GetPermission(int id)
        {
            return await _repository.GetPermission(id);
        }

        public async Task<Permission> Create(RDTOPermission permission)
        {
            Permission newPermission = new()
            {
                PermissionName = permission.PermissionName,
            };
            return await _repository.Create(newPermission);
        }

        public Task<Permission> Update(int id, RDTOPermission permission)
        {
            return _repository.Update(id, permission);
        }
    }
}
