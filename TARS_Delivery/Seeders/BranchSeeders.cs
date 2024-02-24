using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Seeders
{
    public class BranchSeeders
    {
        public BranchSeeders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>().HasData(
                new Branch
                {
                    Id = 1,
                    BranchName = "TARS Delivery",
                    PhoneNumber = "123456789",
                    Address = "1234 TARS Street",
                    Province = "TARS",
                    District = "TARS",
                    PostalCode = "1234",
                    Status = EStatusData.Active
                },
                new Branch
                {
                    Id = 2,
                    BranchName = "TARS Delivery 2",
                    PhoneNumber = "123456789",
                    Address = "1234 TARS Street",
                    Province = "TARS",
                    District = "TARS",
                    PostalCode = "1234",
                    Status = EStatusData.Active
                },
                new Branch
                {
                    Id = 3,
                    BranchName = "TARS Delivery 3",
                    PhoneNumber = "123456789",
                    Address = "1234 TARS Street",
                    Province = "TARS",
                    District = "TARS",
                    PostalCode = "1234",
                    Status = EStatusData.Active
                }
            );
        }
    }
}
