using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository repository;
        public RoleService(IRoleRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Role>> GetRoles()
        {
            return await repository.GetRoles();
        }

        public async Task<Role> GetRole(int id)
        {
            return await repository.GetRole(id);
        }

        public async Task<Role> Create(Role RolePost)
        {
            return await repository.Create(RolePost);
        }

        //public async Task<Role> Update(Role role)
        //{
        //    return await repository.Update(role);
        //}
    }
}
