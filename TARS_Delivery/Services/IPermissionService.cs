
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services
{
    public interface IPermissionService
    {
        Task<IEnumerable<Permission>> GetPermissions();
        Task<Permission> GetPermission(int id);
        Task<Permission> Create(Permission permission);
        Task<Permission> Update(int id, RDTOPermisson permission);
        Task<Permission> Delete(int id);
    }
}
