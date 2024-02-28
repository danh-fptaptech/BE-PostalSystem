
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services
{
    public interface IPermissionService
    {
        Task<IEnumerable<Permission>> GetPermissions();
        Task<Permission> GetPermission(string permissionName);
        Task<IEnumerable<Permission>> GetPermissionsByName(IEnumerable<string> permissionNames);
        Task<Permission> Create(RDTOPermission permission);
        Task<Permission> Update(string permissionName, RDTOPermission permission);
    }
}
