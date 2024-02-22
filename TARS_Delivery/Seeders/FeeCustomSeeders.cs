using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Seeders
{
    public class FeeCustomSeeders
    {
        public FeeCustomSeeders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeeCustom>().HasData(
                new FeeCustom
                {
                    Id = 1,
                    ServiceId = 1, // EMS Delivery Service
                    LocationIdFrom = 2, // Quận 1
                    LocationIdTo = 3, // Quận 2
                    Distance = 15.5m,
                    FeeCharge = 35000.00m,
                    TimeProcess = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new FeeCustom
                {
                    Id = 2,
                    ServiceId = 2, // Freight Delivery Services
                    LocationIdFrom = 2, // Quận 1
                    LocationIdTo = 3, // Quận 7
                    Distance = 25.0m,
                    FeeCharge = 45000.00m,
                    TimeProcess = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new FeeCustom
                {
                    Id = 3,
                    ServiceId = 3, // Express Delivery
                    LocationIdFrom = 2, // Quận 1
                    LocationIdTo = 3, // Quận 2
                    Distance = 30.0m,
                    FeeCharge = 50000.00m,
                    TimeProcess = 5,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new FeeCustom
                {
                    Id = 4,
                    ServiceId = 1, // EMS Delivery Service
                    LocationIdFrom = 2, // TP HCM
                    LocationIdTo = 3, // TP HCM (nội thành)
                    Distance = 15.0m, // Giá trị ước tính cho cự ly nội thành
                    FeeCharge = 60000.00m,
                    TimeProcess = 24,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                }
            );
        }
    }
}
