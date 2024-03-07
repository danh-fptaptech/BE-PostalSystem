﻿using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders
{
    public class PackageSeeders
    {
        public PackageSeeders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Package>().HasData(
            new Package
            {
                Id = 1,
                TrackingCode = "123456789",
                NameFrom = "Nguyễn Văn A",
                AddressFrom = "Số 1, Đường 1, Phường 1, Quận 1, TP HCM",
                PostalCodeFrom = "700000",
                PhoneFrom = "0123456789",
                NameTo = "Trần Thị B",
                AddressTo = "Số 2, Đường 2, Phường 2, Quận 2, TP HCM",
                PhoneTo= "0123456789",
                TimeProcess= 3,
                PackageType= Models.Enums.EItemType.Pack,
                PostalCodeTo = "700000",
                PackageNote = "Giao hàng cẩn thận",
                TotalFee = 100000,
                ServiceId = 1,
                UserId = 1,
                Step = Models.Enums.EPackageStatus.WaitingForPickup,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Status = Models.Enums.EStatusData.Active
            },
            new Package
            {
                Id = 2,
                TrackingCode = "987654321",
                NameFrom = "Trần Thị B",
                AddressFrom = "Số 2, Đường 2, Phường 2, Quận 2, TP HCM",
                PhoneFrom = "0123456789",
                PostalCodeFrom = "700000",
                NameTo = "Lê Văn C",
                AddressTo = "Số 3, Đường 3, Phường 3, Quận 3, TP HCM",
                PhoneTo = "0123456789",
                TimeProcess=5,
                PackageType = Models.Enums.EItemType.Document,
                PostalCodeTo = "700000",
                PackageNote = "Giao hàng cẩn thận",
                TotalFee = 100000,
                ServiceId = 1,
                UserId = 2,
                Step = Models.Enums.EPackageStatus.WaitingForPickup,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Status = Models.Enums.EStatusData.Active
            }
            );
        }
    }
}
