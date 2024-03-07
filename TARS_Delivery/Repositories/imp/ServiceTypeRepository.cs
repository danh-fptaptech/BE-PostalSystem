using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Repositories.imp
{
    public class ServiceTypeRepository : IServiceTypeRepository
    {
        private readonly DatabaseContext _context;
        public ServiceTypeRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<ServiceType> ChangeStatus(int id)
        {
           var serviceType = await GetServiceTypeById(id);
            if (serviceType == null)
            {
                return null;
            }

            serviceType.Status = serviceType.Status == EStatusData.Active ? EStatusData.Inactive : EStatusData.Active;
            await _context.SaveChangesAsync();
            return serviceType;
        }

        public async Task<ServiceType> CreateServiceType(ServiceType serviceType)
        {
            _context.ServiceTypes.Add(serviceType);
            await _context.SaveChangesAsync();
            return await _context.ServiceTypes.FindAsync(serviceType.Id);
        }

        public async Task<ICollection<ServiceType>> GetAllServiceTypes()
        {
            var serviceTypes = await _context.ServiceTypes.ToListAsync();
            return serviceTypes;
        }
        public async Task<ServiceType> GetServiceTypeById (int id)
        {
            var serviceType = await _context.ServiceTypes.FindAsync(id);
            return serviceType;
        }
        public async Task<ServiceType> GetChildServiceTypeById(int id)
        {
            var serviceType = await _context.ServiceTypes
                .Include(s => s.Services)
                .FirstOrDefaultAsync(s => s.Id == id);
            if (serviceType == null)
            {
                return null;
            }
            var listService = await _context.Services.Where(s => s.ServiceTypeId == id).ToListAsync();
            var returnService = new ServiceType
            {
                Id = serviceType.Id,
                ServiceName = serviceType.ServiceName,
                ServiceDescription = serviceType.ServiceDescription,
                Status = serviceType.Status,
                CreatedAt = serviceType.CreatedAt,
                UpdatedAt = serviceType.UpdatedAt,
                Services = listService.Count>0? listService : null,
            };
            return serviceType;
        }

        public async Task<ServiceType> UpdateServiceType(ServiceType serviceType)
        {
            var ServiceTypeCurrent = await GetServiceTypeById(serviceType.Id);
            if (ServiceTypeCurrent == null)
            {
                return null;
            }
            _context.Entry(ServiceTypeCurrent).CurrentValues.SetValues(serviceType);
            await _context.SaveChangesAsync();
            return await _context.ServiceTypes.FindAsync(serviceType.Id);
        }
    }
}
