using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;
using TARS_Delivery.Providers;

namespace TARS_Delivery.Seeders
{
    public class EmployeeSeeders
    {
        public EmployeeSeeders(ModelBuilder modelBuilder)
        {
            IHashProvider hashProvider = new HashProvider();

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    EmployeeCode = "EMP-000001",
                    Email = "admin@tars.com",
                    Password = hashProvider.Hash("admintars"),
                    Fullname = "Nguyễn Văn Chủ",
                    Address = "Số 1 Đường 1 Phường 1, Quận 1, TP HCM",
                    Province = "TP HCM",
                    District = "Quận 1",
                    PostalCode = "700000",
                    PhoneNumber = "012345678",
                    Avatar = "avatar.jpg",
                    SubmitedInfo = null,
                    BranchId = 1,
                    RoleId = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Employee
                {
                    Id = 2,
                    EmployeeCode = "EMP-000002",
                    Email = "managerbranch02@tars.com",
                    Password = hashProvider.Hash("managerbranch"),
                    Fullname = "Trần Thị A",
                    Address = "Số 2 Đường 2 Phường 2, Quận 2, TP HCM",
                    Province = "TP HCM",
                    District = "Quận 2",
                    PhoneNumber = "0987654321",
                    PostalCode = "700000",
                    Avatar = "avatar.jpg",
                    SubmitedInfo = null,
                    BranchId = 2,
                    RoleId = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Employee
                {
                    Id = 3,
                    EmployeeCode = "EMP-000003",
                    Email = "warehousebranch03@tars.com",
                    Password = hashProvider.Hash("123"),
                    Fullname = "Lê Văn B",
                    Address = "Số 3 Đường 3 Phường 3, Quận 3, TP HCM",
                    Province = "TP HCM",
                    District = "Quận 3",
                    PhoneNumber = "2548897451",
                    PostalCode = "700000",
                    Avatar = "avatar.jpg",
                    SubmitedInfo = null,
                    BranchId = 3,
                    RoleId = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Employee
                {
                    Id = 4,
                    EmployeeCode = "EMP-000004",
                    Email = "delivery@tars.com",
                    Password = hashProvider.Hash("123"),
                    Fullname = "Lê Văn C",
                    Address = "Số 3 Đường 3 Phường 3, Quận 3, TP HCM",
                    Province = "TP HCM",
                    District = "Quận 3",
                    PhoneNumber = "1254889745",
                    PostalCode = "700000",
                    Avatar = "avatar.jpg",
                    SubmitedInfo = null,
                    BranchId = 1,
                    RoleId = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                }

            );
        }
    }
}
