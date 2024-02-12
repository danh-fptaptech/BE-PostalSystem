using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories
{
    public interface IPermissionRepository
    {
        Task<IEnumerable<Permission>> GetPermissions();
        Task<Permission> GetPermission(int id);
        Task<Permission> Create(Permission permission);
        Task<Permission> Update(int id, RDTOPermission permission);
        //Task<Permission> SetPermission(RDTOSetPermission permission);
    }
}
