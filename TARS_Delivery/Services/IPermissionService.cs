using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services
{
    public interface IPermissionService
    {
        Task<IEnumerable<Permission>> GetPermissions();
        Task<Permission> GetPermission(int id);
        Task<Permission> Create(Permission permission);
        Task<Permission> Update(int id, Permission permission);
        Task<Permission> Delete(int id);
    }
}
