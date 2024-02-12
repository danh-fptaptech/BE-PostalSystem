
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services
{
    public interface IPermissionService
    {
        Task<IEnumerable<Permission>> GetPermissions();
        Task<Permission> GetPermission(int id);
        Task<Permission> Create(RDTOPermission permission);
        Task<Permission> Update(int id, RDTOPermission permission);
    }
}
