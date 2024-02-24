using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders
{
    public class UserSeeders
    {
        public UserSeeders (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                User.Register("Nguyễn Văn User", "usera@usera", "0123456789", "123", "avatar.jpg"),
                User.Register("Trần Văn User", "userb@userb", "0987654321", "123", "avatar.jpg"),
                User.Register("Lê Văn User", "userc@userc", "023023920392", "123", "avatar.jpg")
            );
        }
    }
}
