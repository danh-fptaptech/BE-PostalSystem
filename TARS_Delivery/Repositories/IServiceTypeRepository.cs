using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories
{
    public interface IServiceTypeRepository
    {
        Task<ICollection<ServiceType>> GetAllServiceTypes();
        Task<ServiceType> GetServiceTypeById(int id);
        Task<ServiceType> GetChildServiceTypeById(int id);
        Task<ServiceType> CreateServiceType(ServiceType serviceType);
        Task<ServiceType> UpdateServiceType(ServiceType serviceType);
        Task<ServiceType> ChangeStatus(int id);
    }
}
