using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req.Service;
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
        Task<List<Service>> GetServicesByWeight(int weight);
        Task<List<Service>> ValidateWeight(int serviceTypeId,int weightFrom, int weightTo,int serviceId);
        Task<List<RDTORange>> AlowRange(int serviceTypeId);
    }
}
