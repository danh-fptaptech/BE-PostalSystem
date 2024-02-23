using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders;

public class RoleSeeders
{
    public RoleSeeders(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1, RoleName = "Admin"},
            new Role { Id = 2, RoleName = "Branch Manager"},
            new Role { Id = 3, RoleName = "Warehouse"},
            new Role { Id = 4, RoleName = "Delivery"}
        );
    }
}