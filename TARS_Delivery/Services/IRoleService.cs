
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services
{
    public interface IRoleService
    {
        Task<IEnumerable<SDTORole>> GetRoles();
        Task<SDTORole> GetRole(int id);
        Task<Role> Create(RDTORole role);
        Task<Role> Update(int id, RDTORole role);
        Task<Role> Delete(int id);
    }
}
