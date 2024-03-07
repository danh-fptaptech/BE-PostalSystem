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
                    PermissionName = "app.view",
                },
                new Permission
                {
                    Id = 2,
                    PermissionName = "branch.view",
                },
                new Permission
                {
                    Id = 3,
                    PermissionName = "branch.create",
                },
                new Permission
                {
                    Id = 4,
                    PermissionName = "branch.update",
                },
                new Permission
                {
                    Id = 5,
                    PermissionName = "branch.disable",
                },
                new Permission
                {
                    Id = 6,
                    PermissionName = "package.create",
                },
                new Permission
                {
                    Id = 7,
                    PermissionName = "package.update",
                },
                new Permission
                {
                    Id = 8,
                    PermissionName = "package.disable",
                },
                new Permission
                {
                    Id = 9,
                    PermissionName = "package.view",
                },
                new Permission
                {
                    Id = 10,
                    PermissionName = "user.info",
                },
                new Permission
                {
                    Id = 11,
                    PermissionName = "user.create",
                },
                new Permission
                {
                    Id = 12,
                    PermissionName = "user.update",
                },
                new Permission
                {
                    Id = 13,
                    PermissionName = "user.disable",
                },
                new Permission
                {
                    Id = 14,
                    PermissionName = "user.view",
                },
                new Permission
                {
                    Id = 15,
                    PermissionName = "role.create",
                },
                new Permission
                {
                    Id = 16,
                    PermissionName = "role.update",
                },
                new Permission
                {
                    Id = 17,
                    PermissionName = "role.disable",
                },
                new Permission
                {
                    Id = 18,
                    PermissionName = "role.view",
                },
                new Permission
                {
                    Id = 19,
                    PermissionName = "service.create",
                },
                new Permission
                {
                    Id = 20,
                    PermissionName = "service.update",
                },
                new Permission
                {
                    Id = 21,
                    PermissionName = "service.disable",
                },
                new Permission
                {
                    Id = 22,
                    PermissionName = "service.view",
                },
                new Permission
                {
                    Id = 23,
                    PermissionName = "fee.create",
                },
                new Permission
                {
                    Id = 24,
                    PermissionName = "fee.update",
                },
                new Permission
                {
                    Id = 25,
                    PermissionName = "fee.disable",
                },
                new Permission
                {
                    Id = 26,
                    PermissionName = "fee.view",
                },
                new Permission
                {
                    Id = 27,
                    PermissionName = "emp.create",
                },
                new Permission
                {
                    Id = 28,
                    PermissionName = "emp.update",
                },
                new Permission
                {
                    Id = 29,
                    PermissionName = "emp.disable",
                },
                new Permission
                {
                    Id = 30,
                    PermissionName = "emp.view",
                },
                new Permission
                {
                    Id = 31,
                    PermissionName = "emp.submitinfo",
                },
                new Permission
                {
                    Id = 32,
                    PermissionName = "emp.viewinfo",
                },
                new Permission
                {
                    Id = 33,
                    PermissionName = "blog.create",
                },
                new Permission
                {
                    Id = 34,
                    PermissionName = "blog.update",
                },
                new Permission
                {
                    Id = 35,
                    PermissionName = "blog.disable",
                },
                new Permission
                {
                    Id = 36,
                    PermissionName = "ticket.create",
                },
                new Permission
                {
                    Id = 37,
                    PermissionName = "ticket.update",
                },
                new Permission
                {
                    Id = 38,
                    PermissionName = "ticket.disable",
                },
                new Permission
                {
                    Id = 39,
                    PermissionName = "ticket.addemp",
                },
                new Permission
                {
                    Id = 40,
                    PermissionName = "ticket.view",
                },
                new Permission
                {
                    Id = 41,
                    PermissionName = "profile.view",
                }, 
                new Permission
                {
                    Id = 42,
                    PermissionName = "role.delete",
                },
                new Permission
                {
                    Id = 43,
                    PermissionName = "users.view",
                },
                new Permission
                {
                    Id = 44,
                    PermissionName = "locations.view",
                },
                new Permission
                {
                    Id = 45,
                    PermissionName = "checkFee.view",
                },
                new Permission
                {
                    Id = 46,
                    PermissionName = "users.view",
                },
                new Permission
                {
                    Id = 47,
                    PermissionName = "request.view",
                },
                new Permission
                {
                    Id = 48,
                    PermissionName = "packages.view",
                },
                new Permission
                {
                    Id = 49,
                    PermissionName = "password.change",
                },
                new Permission
                {
                    Id = 50,
                    PermissionName = "addresses.view",
                },
                new Permission
                {
                    Id = 51,
                    PermissionName = "addresses.create",
                },
                new Permission
                {
                    Id = 52,
                    PermissionName = "servicetype.view",
                }
            );
        }
    }
}