﻿
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _repository;
        public RoleService(IRoleRepository repository) 
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Role>> GetRoles()
        {
            return await _repository.GetRoles();
        }

        public async Task<Role> GetRole(int id)
        {
            return await _repository.GetRole(id);
        }

        public async Task<Role> Create(RDTORole role)
        {
            Role newRole = new()
            {
                RoleName = role.RoleName,
                Status = role.Status,
            };
            return await _repository.Create(newRole);
        }

        public async Task<Role> Update(int id, RDTORole role)
        {
            return await _repository.Update(id, role);
        }

        public Task<Role> Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Task<SDTORole> GetRoleWithPermissions(int id)
        {
            return _repository.GetRoleWithPermissions(id);
        }

        public Task<IEnumerable<SDTORole>> GetRolesWithPermissions()
        {
            return _repository.GetRolesWithPermissions();
        }

        public Task<SDTORole> AddPermission(int roleId, int permissionId)
        {
            return _repository.AddPermission(roleId, permissionId);
        }

        public Task DeletePermission(int roleId, int permissionId)
        {
            return _repository.DeletePermission(roleId, permissionId);
        }
    }
}
