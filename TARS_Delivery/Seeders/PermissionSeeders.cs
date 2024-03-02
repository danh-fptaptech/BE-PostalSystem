using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders
{
    public class PermissionSeeders
    {
        public PermissionSeeders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>().HasData(
                new Permission
                {
                    Id = 1,
                    PermissionName = "Admin",
                },
                new Permission
                {
                    Id = 2,
                    PermissionName = "User",
                },
                new Permission
                {
                    Id = 3,
                    PermissionName = "Employee",
                }
            );
        }
    }
}
