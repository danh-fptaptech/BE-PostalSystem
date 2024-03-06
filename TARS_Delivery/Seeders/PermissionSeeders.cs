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
                },
                new Permission
                {
                    Id = 4,
                    PermissionName = "Branch Manager",
                },
                new Permission
                {
                    Id = 5,
                    PermissionName = "Warehouse",
                },
                new Permission
                {
                    Id = 6,
                    PermissionName = "Delivery",
                }
            );
        }
    }
}
