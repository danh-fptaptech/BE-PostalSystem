using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Seeders
{
    public class FeeCustomSeeders
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeeCustom>().HasData(
                new FeeCustom
                {
                    Id = 1,
                    ServiceId = 1, // EMS Delivery Service
                    PostalCodeFrom = 700000, // TP HCM
                    PostalCodeTo = 713000, // Quận 2
                    Distance = 15.5m,
                    FeeCharge = 35000.00m,
                    TimeProcess = 48,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new FeeCustom
                {
                    Id = 2,
                    ServiceId = 2, // Freight Delivery Services
                    PostalCodeFrom = 700000, // TP HCM
                    PostalCodeTo = 756000, // Quận 7
                    Distance = 25.0m,
                    FeeCharge = 45000.00m,
                    TimeProcess = 72,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new FeeCustom
                {
                    Id = 3,
                    ServiceId = 3, // Express Delivery
                    PostalCodeFrom = 700000, // TP HCM
                    PostalCodeTo = 710100, // Quận 1
                    Distance = 5.0m,
                    FeeCharge = 25000.00m,
                    TimeProcess = 24,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new FeeCustom
                {
                    Id = 4,
                    ServiceId = 1, // EMS Delivery Service
                    PostalCodeFrom = 700000, // TP HCM
                    PostalCodeTo = 700000, // TP HCM (nội thành)
                    Distance = 10.0m, // Giá trị ước tính cho cự ly nội thành
                    FeeCharge = 20000.00m,
                    TimeProcess = 48,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new FeeCustom
                {
                    Id = 5,
                    ServiceId = 3, // Express Delivery
                    PostalCodeFrom = 700000, // TP HCM
                    PostalCodeTo = 700010, // Đồng Nai
                    Distance = 30.0m, // Giá trị ước tính
                    FeeCharge = 40000.00m,
                    TimeProcess = 24,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new FeeCustom
                {
                    Id = 6,
                    ServiceId = 3, // Express Delivery
                    PostalCodeFrom = 700000, // TP HCM
                    PostalCodeTo = 700000, // TP HCM (nội thành)
                    Distance = 5.0m, // Giá trị ước tính
                    FeeCharge = 50000.00m,
                    TimeProcess = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                }
            );
        }
    }
}
