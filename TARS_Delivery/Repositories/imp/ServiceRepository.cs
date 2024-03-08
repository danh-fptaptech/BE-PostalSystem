using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req.Service;
using TARS_Delivery.Models.Entities;
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
            var service = await _context.Services.FindAsync(id);
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
            var services = await _context.Services.Select(s=> new Service
            {
                Id = s.Id,
                ServiceTypeId = s.ServiceTypeId,
                WeighFrom = s.WeighFrom,
                WeighTo = s.WeighTo,
                CreatedAt = s.CreatedAt,
                UpdatedAt = s.UpdatedAt,
                Status = s.Status,
                ServiceType = _context.ServiceTypes.Where(st => st.Id == s.ServiceTypeId).FirstOrDefault()
            }).ToListAsync();

            return services;
        }

        public async Task<Service> GetServiceById(int id)   
        {
            var service = await _context.Services.Select(s => new Service
            {
                Id = s.Id,
                ServiceTypeId = s.ServiceTypeId,
                WeighFrom = s.WeighFrom,
                WeighTo = s.WeighTo,
                CreatedAt = s.CreatedAt,
                UpdatedAt = s.UpdatedAt,
                Status = s.Status,
                ServiceType = _context.ServiceTypes.Where(st => st.Id == s.ServiceTypeId).FirstOrDefault()
            }).Where(s => s.Id == id).FirstOrDefaultAsync();
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
            var services = await _context.Services.Select(s => new Service
            {
                Id = s.Id,
                ServiceTypeId = s.ServiceTypeId,
                WeighFrom = s.WeighFrom,
                WeighTo = s.WeighTo,
                CreatedAt = s.CreatedAt,
                UpdatedAt = s.UpdatedAt,
                Status = s.Status,
                ServiceType = _context.ServiceTypes.Where(st => st.Id == s.ServiceTypeId).FirstOrDefault()
            }).Where(s => s.WeighFrom <= weight && s.WeighTo >= weight).ToListAsync();
            return services;
        }
        public async Task<List<Service>> ValidateWeight(int serviceTypeId, int weightFrom, int weightTo, int serviceId)
        {
            if (serviceId == 0)
            {
                var services = await _context.Services
                .Where(s => s.ServiceTypeId == serviceTypeId &&
                        ((s.WeighFrom <= weightFrom && s.WeighTo >= weightFrom) ||
                        (s.WeighFrom <= weightTo && s.WeighTo >= weightTo)))
                .ToListAsync();

                return services;
            }
            else
            {
                var services = await _context.Services
                .Where(s => s.ServiceTypeId == serviceTypeId &&
                        s.Id != serviceId &&
                        ((s.WeighFrom <= weightFrom && s.WeighTo >= weightFrom) ||
                        (s.WeighFrom <= weightTo && s.WeighTo >= weightTo)))
                .ToListAsync();

                return services;
            }
        }
        public async Task<List<RDTORange>> AlowRange(int serviceTypeId)
        {
            var services = await _context.Services
                .Where(s => s.ServiceTypeId == serviceTypeId)
                .OrderBy(s => s.WeighFrom)
                .ToListAsync();
            var listRange = new List<RDTORange>();
            if (services.Count > 1)
            {
                for (int i = 0; i < services.Count - 1; i++)
                {
                    if (services[i + 1].WeighFrom - services[i].WeighTo > 1)
                    {
                        listRange.Add(new RDTORange { From = services[i].WeighTo, To = services[i + 1].WeighFrom });
                    }
                }
                if (services[services.Count-1].WeighTo < 999999999)
                {
                    listRange.Add(new RDTORange { From = services[services.Count-1].WeighTo, To = 999999999 });
                }
            }
            else if (services.Count == 1)
            {
                if (services[0].WeighTo==0)
                {
                    listRange.Add(new RDTORange { From = 0, To = services[0].WeighFrom });
                    if (services[0].WeighFrom <= 999999999)
                    {
                        listRange.Add(new RDTORange { From = services[0].WeighTo, To = 999999999 });
                    }
                }
            }
            return listRange;
        }
    }
}
