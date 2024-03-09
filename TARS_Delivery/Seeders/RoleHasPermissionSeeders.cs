using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders
{
    public class RoleHasPermissionSeeders
    {
        public RoleHasPermissionSeeders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleHasPermission>().HasData(
            // Admin
            new RoleHasPermission {
                PermissionId = 1,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 2,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 3,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 4,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 5,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 9,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 15,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 18,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 42,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 23,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 24,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 25,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 26,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 27,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 28,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 29,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 30,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 31,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 32,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 33,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 34,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 35,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 36,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 37,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 38,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 39,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 47,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 48,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 52,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 53,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 54,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 55,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 56,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 57,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 58,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 59,
                RoleId = 1
            },
            new RoleHasPermission
            {
                PermissionId = 60,
                RoleId = 1
            },

            // Branch Manager
            new RoleHasPermission
            {
                PermissionId = 1,
                RoleId = 2
            },
            new RoleHasPermission
            {
                PermissionId = 2,
                RoleId = 2
            },
            new RoleHasPermission
            {
                PermissionId = 9,
                RoleId = 2
            },
            new RoleHasPermission
            {
                PermissionId = 22,
                RoleId = 2
            },
            new RoleHasPermission
            {
                PermissionId = 26,
                RoleId = 2
            },
            new RoleHasPermission
            {
                PermissionId = 30,
                RoleId = 2
            }, new RoleHasPermission
            {
                PermissionId = 36,
                RoleId = 2
            },
            new RoleHasPermission
            {
                PermissionId = 37,
                RoleId = 2
            },
            new RoleHasPermission
            {
                PermissionId = 38,
                RoleId = 2
            },
            new RoleHasPermission
            {
                PermissionId = 39,
                RoleId = 2
            },
            new RoleHasPermission
            {
                PermissionId = 40,
                RoleId = 2
            },
            new RoleHasPermission
            {
                PermissionId = 41,
                RoleId = 2
            },
            new RoleHasPermission
            {
                PermissionId = 53,
                RoleId = 2
            },

            // Warehouse
            new RoleHasPermission
            {
                PermissionId = 1,
                RoleId = 3
            },
            new RoleHasPermission
            {
                PermissionId = 2,
                RoleId = 3
            },
            new RoleHasPermission
            {
                PermissionId = 9,
                RoleId = 3
            },
            new RoleHasPermission
            {
                PermissionId = 22,
                RoleId = 3
            },
            new RoleHasPermission
            {
                PermissionId = 26,
                RoleId = 3
            },
            new RoleHasPermission
            {
                PermissionId = 40,
                RoleId = 3
            },
            new RoleHasPermission
            {
                PermissionId = 41,
                RoleId = 3
            },
            new RoleHasPermission
            {
                PermissionId = 54,
                RoleId = 3
            },
            // Delivery
            new RoleHasPermission
            {
                PermissionId = 1,
                RoleId = 4
            },
            new RoleHasPermission
            {
                PermissionId = 2,
                RoleId = 4
            }, 
            new RoleHasPermission
            {
                PermissionId = 8,
                RoleId = 4
            },
            new RoleHasPermission
            {
                PermissionId = 9,
                RoleId = 4
            },
            new RoleHasPermission
            {
                PermissionId = 22,
                RoleId = 4
            },
            new RoleHasPermission
            {
                PermissionId = 26,
                RoleId = 4
            }, 
            new RoleHasPermission
            {
                PermissionId = 37,
                RoleId = 4
            },
            new RoleHasPermission
            {
                PermissionId = 40,
                RoleId = 4
            },
            new RoleHasPermission
            {
                PermissionId = 41,
                RoleId = 4
            },
            new RoleHasPermission
            {
                PermissionId = 55,
                RoleId = 4
            }

            );
        }
    }
}
