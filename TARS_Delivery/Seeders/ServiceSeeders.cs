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
                    ServiceName = "EMS Delivery Service",
                    ServiceDescription = "Fast and secure international delivery service",
                    WeighFrom = 0,
                    WeighTo = 500,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Service
                {
                    Id = 2,
                    ServiceName = "EMS Delivery Service",
                    ServiceDescription = "Fast and secure international delivery service",
                    WeighFrom = 501,
                    WeighTo = 1000,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Service
                {
                    Id = 3,
                    ServiceName = "EMS Delivery Service",
                    ServiceDescription = "Fast and secure international delivery service",
                    WeighFrom = 1001,
                    WeighTo = 2000,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Service
                {
                    Id = 4,
                    ServiceName = "Express Delivery",
                    ServiceDescription = "Fast and convenient express delivery service",
                    WeighFrom = 2001,
                    WeighTo = 3000,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Service
                {
                    Id = 5,
                    ServiceName = "Freight Delivery Services",
                    ServiceDescription = "Reliable freight and cargo delivery solutions",
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
