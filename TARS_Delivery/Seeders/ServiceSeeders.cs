using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Seeders
{
    public class ServiceSeeders
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasData(
                new Service
                {
                    Id = 1,
                    ServiceName = "EMS Delivery Service",
                    ServiceDescription = "Fast and secure international delivery service",
                    ServiceImage = "ems_delivery.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Service
                {
                    Id = 2,
                    ServiceName = "Freight Delivery Services",
                    ServiceDescription = "Reliable freight and cargo delivery solutions",
                    ServiceImage = "freight_delivery.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Service
                {
                    Id = 3,
                    ServiceName = "Express Delivery",
                    ServiceDescription = "Fast and convenient express delivery service",
                    ServiceImage = "express_delivery.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                }
            );
        }
    }
}
