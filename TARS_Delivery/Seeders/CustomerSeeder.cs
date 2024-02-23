using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders
{
    public class CustomerSeeder
    {
        public CustomerSeeder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer> ().HasData(
                new Customer
                {
                    Id = 1,
                    UserId = 1,
                    Name = "Nguyễn Văn Customer",
                    PhoneNumber = "0123456789",
                    Address = "Số 1, Đường 1, Phường 1, Quận 1, TP HCM",
                    Province = "TP HCM",
                    District = "Quận 1",
                    TypeInfo = Models.Enums.ETypeInfo.Sender,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = Models.Enums.EStatusData.Active
                },
                new Customer
                {
                    Id = 2,
                    UserId = 2,
                    Name = "Trần Thị Customer",
                    PhoneNumber = "0987654321",
                    Address = "Số 2, Đường 2, Phường 2, Quận 2, TP HCM",
                    Province = "TP HCM",
                    District = "Quận 2",
                    TypeInfo = Models.Enums.ETypeInfo.Receiver,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = Models.Enums.EStatusData.Active
                },
                new Customer
                {
                    Id = 3,
                    UserId = 3,
                    Name = "Lê Văn Customer",
                    PhoneNumber = "044333333",
                    Address = "Số 3, Đường 3, Phường 3, Quận 3, TP HCM",
                    Province = "TP HCM",
                    District = "Quận 3",
                    TypeInfo = Models.Enums.ETypeInfo.Sender,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = Models.Enums.EStatusData.Active
                }
            );
        }
    }
}
