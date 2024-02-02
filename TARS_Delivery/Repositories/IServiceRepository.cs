using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories
{
    public interface IServiceRepository
    {
        Task<ICollection<Service>> GetAllServices();
        Task<Service> GetServiceById(int id);
        Task<Service> CreateService(Service service);
        Task<Service> UpdateService(int id, Service service);
        Task DeleteService(int id);
        Task<Service> ChangeStatus(int id);
    }
}
