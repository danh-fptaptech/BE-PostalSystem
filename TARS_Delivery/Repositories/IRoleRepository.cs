using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories
{
    public interface IRoleRepository
    {
        Task<IEnumerable<Role>> GetRoles();
        Task<Role> GetRole(int id);
        Task<Role> Create(Role role );
        Task<Role> Update(int id, RDTORole role );
        Task<Role> Delete(int id);
        Task<SDTORole> GetRoleWithPermissions(int id);
        Task<IEnumerable<SDTORole>> GetRolesWithPermissions();
        Task<SDTORole> AddPermission(int roleId, int permissionId);
        Task DeletePermission(int roleId, int permissionId);
    }
}
