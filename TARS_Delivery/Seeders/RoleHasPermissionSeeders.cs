using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders
{
    public class RoleHasPermissionSeeders
    {
        public RoleHasPermissionSeeders(ModelBuilder modelBuilder)
        {
            for (int i = 1; i <= 41; i++)
            {
                modelBuilder.Entity<RoleHasPermission>().HasData(
                    new RoleHasPermission
                    {
                        PermissionId = i,
                        RoleId = 1
                    }
                );
            };
        }
    }
}
