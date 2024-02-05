using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Seeders
{
    public class LocationSeeders
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = 1,
                    LocationName = "TP HCM",
                    PostalCode = 700000,
                    LocationLevel = ELocationLevel.City,
                    LocationOf = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 2,
                    LocationName = "Quận 1",
                    PostalCode = 710100,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 3,
                    LocationName = "Quận 2",
                    PostalCode = 713000,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 4,
                    LocationName = "Quận 3",
                    PostalCode = 722000,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 5,
                    LocationName = "Quận 4",
                    PostalCode = 754000,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 6,
                    LocationName = "Quận 5",
                    PostalCode = 748000,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 7,
                    LocationName = "Quận 6",
                    PostalCode = 746000,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 8,
                    LocationName = "Quận 7",
                    PostalCode = 756000,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 9,
                    LocationName = "Quận 8",
                    PostalCode = 751500,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 10,
                    LocationName = "Quận 9",
                    PostalCode = 715000,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 11,
                    LocationName = "Quận 10",
                    PostalCode = 740010,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 12,
                    LocationName = "Quận 11",
                    PostalCode = 743800,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 13,
                    LocationName = "Quận 12",
                    PostalCode = 729400,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 14,
                    LocationName = "Quận Gò Vấp",
                    PostalCode = 727010,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 15,
                    LocationName = "Quận Tân Bình",
                    PostalCode = 736090,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 16,
                    LocationName = "Quận Tân Phú",
                    PostalCode = 760000,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 17,
                    LocationName = "Quận Phú Nhuận",
                    PostalCode = 725060,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 18,
                    LocationName = "Quận Bình Thạnh",
                    PostalCode = 718440,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 19,
                    LocationName = "Quận Thủ Đức",
                    PostalCode = 720150,
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                }
            );
        }
    }
}
