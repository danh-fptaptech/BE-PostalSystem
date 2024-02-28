
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services
{
    public interface IRoleService
    {
        Task<IEnumerable<Role>> GetRoles();
        Task<Role> GetRole(int id);
        Task<Role> Create(RDTORole role);
        Task<Role> Update(int id, RDTORole role);
        Task<Role> Delete(int id);
        Task<IEnumerable<SDTORole>> GetRolesWithPermissions();
        Task<SDTORole> GetRoleWithPermissions(int roleId);
        Task<SDTORole> AddPermission(int roleId, IEnumerable<string> permissionNames);
        Task DeletePermission(int roleId, string permissionName);
    }
}
