using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders
{
    public class RoleHasPermissionSeeders
    {
        public RoleHasPermissionSeeders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleHasPermission>().HasData(
            
            new RoleHasPermission{
                PermissionId = 1,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 2,
                RoleId = 1
            }
            );
        }
    }
}
