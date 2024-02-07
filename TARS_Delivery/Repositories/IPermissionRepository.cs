using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories
{
    public interface IPermissionRepository
    {
        Task<IEnumerable<Permission>> GetPermissions();

        Task<Permission> GetPermission(int id);

        Task<Permission> Create(Permission permission);

        Task<Permission> Remove(int id);
    }
}
