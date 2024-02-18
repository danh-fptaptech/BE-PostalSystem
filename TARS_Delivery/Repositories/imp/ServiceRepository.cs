using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enum;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly DatabaseContext _context;
        public ServiceRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Service> ChangeStatus(int id)
        {
            var service = await GetServiceById(id);
            if (service == null)
            {
                return null;
            }

            service.Status = service.Status == EStatusData.Active ? EStatusData.Inactive : EStatusData.Active;
            await _context.SaveChangesAsync();
            return service;
        }

        public async Task<Service> CreateService(Service service)
        {
            _context.Services.Add(service);
            await _context.SaveChangesAsync();
            return await _context.Services.FindAsync(service.Id);
        }

        public async Task DeleteService(int id)
        {
            var service = await _context.Services.FindAsync(id);
            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Service>> GetAllServices()
        {
            var services = await _context.Services.ToListAsync();
            return services;
        }

        public async Task<Service> GetServiceById(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return null;
            }

            return service;
        }

        public async Task<Service> UpdateService(int id, Service service)
        {
            var serviceToUpdate = await _context.Services.FindAsync(id);
            if (serviceToUpdate != null)
            {
                service.CreatedAt = serviceToUpdate.CreatedAt;
                service.UpdatedAt = DateTime.Now;
                _context.Entry(serviceToUpdate).CurrentValues.SetValues(service);
                await _context.SaveChangesAsync();
                return serviceToUpdate;
            }
            return null;
        }
        public async Task<List<Service>> GetServicesByWeight(int weight)
        {
            /*ETypeService TypeService = ETypeService.kl_0_500;
            if (weight > 500 && weight <= 1000)
            {
                TypeService = ETypeService.kl_501_1000;
            }
            else if (weight > 1000 && weight <= 5000)
            {
                TypeService = ETypeService.kl_1001_5000;
            }
            else if (weight > 5000 && weight <= 10000)
            {
                TypeService = ETypeService.kl_5001_10000;
            }
            else if (weight > 10000 && weight <= 20000)
            {
                TypeService = ETypeService.kl_10001_20000;
            }
            else if (weight > 20000)
            {
                TypeService = ETypeService.kl_ovver_20000;
            }
            var services = await _context.Services.Where(s => s.TypeService == TypeService).ToListAsync();*/
            var services = await _context.Services.Where(s => s.WeighFrom <= weight && s.WeighTo >= weight).ToListAsync();
            return services;
        }
    }
}
