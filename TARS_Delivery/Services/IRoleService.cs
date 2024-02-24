using TARS_Delivery.Models.DTOs;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services
{
    public interface IRoleService
    {
        Task<IEnumerable<Role>> GetRoles();

        Task<Role> GetRole(int id);

        Task<Role> Create(Role RolePost);

        //Task<Role> Update(Role role);
    }
}
