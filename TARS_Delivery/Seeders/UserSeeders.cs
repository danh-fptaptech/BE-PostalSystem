using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders
{
    public class UserSeeders
    {
        public UserSeeders (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Fullname = "Nguyễn Văn User",
                    Email = "usera@usera",
                    Password = "123",
                    Phone = "0123456789",
                    Avatar = "avatar.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = Models.Enums.EStatusData.Active
                },
                new User
                {
                    Id = 2,
                    Fullname = "Trần Thị User",
                    Email = "userb@userb",
                    Password = "123",
                    Phone = "0987654321",
                    Avatar = "avatar.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = Models.Enums.EStatusData.Active
                },
                new User
                {
                    Id = 3,
                    Fullname = "Lê Văn User",
                    Email = "userc@userc",
                    Password = "123",
                    Phone = "023023920392",
                    Avatar = "avatar.jpg",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = Models.Enums.EStatusData.Active
                }
            );
        }
    }
}
