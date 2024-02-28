using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories
{
    public interface IPermissionRepository
    {
        Task<IEnumerable<Permission>> GetPermissions();
        Task<Permission> GetPermission(string permissionName);
        Task<Permission> Create(Permission permission);
        Task<Permission> Update(string permissionName, RDTOPermission permission);
        Task<IEnumerable<Permission>> GetPermissionsByName(IEnumerable<string> permissionNames);
        //Task<Permission> SetPermission(RDTOSetPermission permission);
    }
}
