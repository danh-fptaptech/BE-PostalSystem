using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Seeders
{
    public class ServiceSeeders
    {
        public ServiceSeeders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasData(
                new Service
                {
                    Id = 1,
                    ServiceTypeId = 1,
                    WeighFrom = 0,
                    WeighTo = 500,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Service
                {
                    Id = 2,
                    ServiceTypeId = 1,
                    WeighFrom = 501,
                    WeighTo = 1000,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Service
                {
                    Id = 3,
                    ServiceTypeId = 1,
                    WeighFrom = 1001,
                    WeighTo = 2000,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Service
                {
                    Id = 4,
                    ServiceTypeId = 1,
                    WeighFrom = 2001,
                    WeighTo = 3000,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Service
                {
                    Id = 5,
                    ServiceTypeId = 1,
                    WeighFrom = 3001,
                    WeighTo = 10000,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                }
            );
        }
    }
}
