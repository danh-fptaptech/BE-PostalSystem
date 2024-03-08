using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Seeders;

public class RoleSeeders
{
    public RoleSeeders(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1, RoleName = "Admin", Status = EStatusData.Active },
            new Role { Id = 2, RoleName = "Branch Manager", Status = EStatusData.Active },
            new Role { Id = 3, RoleName = "Warehouse", Status = EStatusData.Active },
            new Role { Id = 4, RoleName = "Delivery", Status = EStatusData.Active },
            new Role { Id = 5, RoleName = "Pickup", Status = EStatusData.Active }
        );
    }
}