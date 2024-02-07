using TARS_Delivery.Models.DTOs;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories
{
    public interface IRoleRepository
    {
        Task<IEnumerable<Role>> GetRoles();
        Task<Role> GetRole(int id);
        Task<Role> Create(Role RolePost);
        //Task<Role> Update(Role role);
    }
}
