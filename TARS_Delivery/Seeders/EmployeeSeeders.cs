using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Seeders
{
    public class EmployeeSeeders
    {
        public EmployeeSeeders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    EmployeeCode = "EMP001",
                    Email = "emp1@emp1",
                    Password = "123",
                    Fullname = "Nguyễn Văn Employee",
                    Address = "Số 1, Đường 1, Phường 1, Quận 1, TP HCM",
                    Province = "TP HCM",
                    District = "Quận 1",
                    PostalCode = "700000",
                    PhoneNumber = "0123456789",
                    Avatar = "avatar.jpg",
                    SubmitedInfo = "SubmitedInfo",
                    BranchId = 1,
                    RoleId = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Employee
                {
                    Id = 2,
                    EmployeeCode = "EMP002",
                    Email = "emp2@emp2",
                    Password = "123",
                    Fullname = "Trần Thị Employee",
                    Address = "Số 2, Đường 2, Phường 2, Quận 2, TP HCM",
                    Province = "TP HCM",
                    District = "Quận 2",
                    PhoneNumber = "0987654321",
                    PostalCode = "700000",
                    Avatar = "avatar.jpg",
                    SubmitedInfo = "SubmitedInfo",
                    BranchId = 2,
                    RoleId = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Employee
                {
                    Id = 3,
                    EmployeeCode = "EMP003",
                    Email = "emp3@emp3",
                    Password = "123",
                    Fullname = "Lê Văn Employee",
                    Address = "Số 3, Đường 3, Phường 3, Quận 3, TP HCM",
                    Province = "TP HCM",
                    District = "Quận 3",
                    PhoneNumber = "12548897451",
                    PostalCode = "700000",
                    Avatar = "avatar.jpg",
                    SubmitedInfo = "SubmitedInfo",
                    BranchId = 3,
                    RoleId = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                }
            );
        }
    }
}
