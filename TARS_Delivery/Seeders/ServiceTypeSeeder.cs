using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Seeders
{
    public class ServiceTypeSeeders
    {
        public ServiceTypeSeeders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceType>().HasData(
                new ServiceType
                {
                    Id = 1,
                    ServiceName = "EMS Delivery Service",
                    ServiceDescription = "Fast and secure international delivery service",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new ServiceType
                {
                    Id = 2,
                    ServiceName = "Express Delivery",
                    ServiceDescription = "Fast and convenient express delivery service",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new ServiceType
                {
                    Id = 3,
                    ServiceName = "Freight Delivery Services",
                    ServiceDescription = "Reliable freight and cargo delivery solutions",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                }
            );
        }
    }
}
