using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Seeders
{
    public class LocationSeeders
    {
        public LocationSeeders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = 1,
                    LocationName = "Ho Chi Minh city",
                    PostalCode = "700000",
                    LocationLevel = ELocationLevel.Province,
                    LocationOf = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 2,
                    LocationName = "District 1",
                    PostalCode = "710000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 3,
                    LocationName = "District 2",
                    PostalCode = "713000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 4,
                    LocationName = "District 3",
                    PostalCode = "722700",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 5,
                    LocationName = "District 4",
                    PostalCode = "754000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 6,
                    LocationName = "District 5",
                    PostalCode = "749000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 7,
                    LocationName = "District 6",
                    PostalCode = "746000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 8,
                    LocationName = "District 7",
                    PostalCode = "756000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 9,
                    LocationName = "District 8",
                    PostalCode = "751000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 10,
                    LocationName = "District 9",
                    PostalCode = "715000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 11,
                    LocationName = "District 10",
                    PostalCode = "740500",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 12,
                    LocationName = "District 11",
                    PostalCode = "743000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 13,
                    LocationName = "District 12",
                    PostalCode = "729110",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 14,
                    LocationName = "Phu Nhuan",
                    PostalCode = "725000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 15,
                    LocationName = "Binh Thanh",
                    PostalCode = "717000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 16,
                    LocationName = "Tan Binh",
                    PostalCode = "736090",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 17,
                    LocationName = "Binh Tan",
                    PostalCode = "762000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 18,
                    LocationName = "Go Vap",
                    PostalCode = "727000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 19,
                    LocationName = "Tan Phu",
                    PostalCode = "760000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 20,
                    LocationName = "Thu Duc",
                    PostalCode = "721400",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 21,
                    LocationName = "Binh Chanh",
                    PostalCode = "738000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 22,
                    LocationName = "Can Gio",
                    PostalCode = "759000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 23,
                    LocationName = "Hoc Mon",
                    PostalCode = "731000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 24,
                    LocationName = "Cu Chi",
                    PostalCode = "733000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 25,
                    LocationName = "Nha Be",
                    PostalCode = "758000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 1, // TP HCM
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                //distric 1
                new Location
                {
                    Id = 26,
                    LocationName = "Tan Đinh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 27,
                    LocationName = "Da Kao",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 28,
                    LocationName = "Ben Nghe",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 29,
                    LocationName = "Ben Thanh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 30,
                    LocationName = "Nguyen Thai Binh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward, 
                    LocationOf = 2, 
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 31,
                    LocationName = "Pham Ngu Lao",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward, 
                    LocationOf = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 32,
                    LocationName = "Cau Ong Lanh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward, 
                    LocationOf = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 33,
                    LocationName = "Co Giang",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward, 
                    LocationOf = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 34,
                    LocationName = "Nguyen Cu Trinh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward, 
                    LocationOf = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 35,
                    LocationName = "Cau Kho",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward, 
                    LocationOf = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                //district 2
                new Location
                {
                    Id = 36,
                    LocationName = "Thanh My Loi",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 37,
                    LocationName = "An Khanh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 38,
                    LocationName = "An Loi Dong",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 39,
                    LocationName = "Thao Dien",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 40,
                    LocationName = "Thu Thiem",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 41,
                    LocationName = "Binh An",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 42,
                    LocationName = "Binh Khanh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 43,
                    LocationName = "Binh Trung Dong",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 44,
                    LocationName = "Binh Trung Tay",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 45,
                    LocationName = "Cat Lai",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 46,
                    LocationName = "Long Binh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                //distric 3
                new Location
                {
                    Id = 47,
                    LocationName = "Phuong 1",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 48,
                    LocationName = "Phuong 2",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 49,
                    LocationName = "Phuong 3",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 50,
                    LocationName = "Phuong 4",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 51,
                    LocationName = "Phuong 5",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 52,
                    LocationName = "Phuong Vo Thi Sau",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 53,
                    LocationName = "Phuong 9",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 54,
                    LocationName = "Phuong 10",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 55,
                    LocationName = "Phuong 11",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 56,
                    LocationName = "Phuong 12",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 57,
                    LocationName = "Phuong 13",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 58,
                    LocationName = "Phuong 14",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                //Ha noi
                new Location
                {
                    Id = 59,
                    LocationName = "Ha Noi",
                    PostalCode = "100000",
                    LocationLevel = ELocationLevel.Province,
                    LocationOf = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                //districts of HN
                new Location
                {
                    Id = 60,
                    LocationName = "Quan Ba Dinh",
                    PostalCode = "118000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 61,
                    LocationName = "Quan Dong Da",
                    PostalCode = "115000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 62,
                    LocationName = "Quan Hai Ba Trung",
                    PostalCode = "113000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 63,
                    LocationName = "Quan Hoan Kiem",
                    PostalCode = "111000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 64,
                    LocationName = "Quan Cau Giay",
                    PostalCode = "122000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 65,
                    LocationName = "Quan Tay Ho",
                    PostalCode = "124000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 66,
                    LocationName = "Quan Hoang Mai",
                    PostalCode = "128100",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 67,
                    LocationName = "Quan Long Bien",
                    PostalCode = "120000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 68,
                    LocationName = "Huyen Dong Anh",
                    PostalCode = "136000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 69,
                    LocationName = "Quan Dong Anh",
                    PostalCode = "136000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 70,
                    LocationName = "Quan Nam Tu Liem",
                    PostalCode = "130000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 71,
                    LocationName = "Quan Tu Liem",
                    PostalCode = "129000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 72,
                    LocationName = "Huyen Phuc Tho",
                    PostalCode = "153600",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 73,
                    LocationName = "Quan Hoan Kiem",
                    PostalCode = "111000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 74,
                    LocationName = "Huyen Soc Son",
                    PostalCode = "139000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 75,
                    LocationName = "Huyen Thach That",
                    PostalCode = "1155300",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 76,
                    LocationName = "Huyen Thanh Tri",
                    PostalCode = "134000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 77,
                    LocationName = "Huyen Thuong Tin",
                    PostalCode = "158501",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 78,
                    LocationName = "Thi Xa Son Tay",
                    PostalCode = "154000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 59,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                //list ward of 60 ba dinh
                // Phường Trúc Bạch
                new Location
                {
                    Id = 79,
                    LocationName = "Trúc Bạch",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 60,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Kim Mã
                new Location
                {
                    Id = 80,
                    LocationName = "Kim Mã",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 60,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Đội Cấn
                new Location
                {
                    Id = 81,
                    LocationName = "Đội Cấn",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 60,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Cống Vị
                new Location
                {
                    Id = 82,
                    LocationName = "Cống Vị",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 60,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Giảng Võ
                new Location
                {
                    Id = 83,
                    LocationName = "Giảng Võ",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 60,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Liễu Giai
                new Location
                {
                    Id = 84,
                    LocationName = "Liễu Giai",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 60,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Ngọc Hà
                new Location
                {
                    Id = 85,
                    LocationName = "Ngọc Hà",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 60,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Thành Công
                new Location
                {
                    Id = 86,
                    LocationName = "Thành Công",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 60,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Ngọc Khánh
                new Location
                {
                    Id = 87,
                    LocationName = "Ngọc Khánh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 60,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Vĩnh Phúc
                new Location
                {
                    Id = 88,
                    LocationName = "Vĩnh Phúc",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 60,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Nguyễn Trung Trực
                new Location
                {
                    Id = 89,
                    LocationName = "Nguyễn Trung Trực",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 60,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                // Phường Phúc Xá
                new Location
                {
                    Id = 90,
                    LocationName = "Phúc Xá",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 60,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Điện Biên
                new Location
                {
                    Id = 91,
                    LocationName = "Điện Biên",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 60,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Quán Thánh
                new Location
                {
                    Id = 92,
                    LocationName = "Quán Thánh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 60,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                //wards of dong ba district 61
                // Phường Quang Trung
                new Location
                {
                    Id = 93,
                    LocationName = "Quang Trung",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Hàng Bột
                new Location
                {
                    Id = 94,
                    LocationName = "Hang Bot",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Phương Liên
                new Location
                {
                    Id = 95,
                    LocationName = "Phuong Lien",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Khương Thượng
                new Location
                {
                    Id = 96,
                    LocationName = "Khuong Thuong",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Thịnh Quang
                new Location
                {
                    Id = 97,
                    LocationName = "Thinh Quang",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Kim Liên
                new Location
                {
                    Id = 98,
                    LocationName = "Kim Lien",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Láng Hạ
                new Location
                {
                    Id = 99,
                    LocationName = "Lang Ha",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Láng Thượng
                new Location
                {
                    Id = 100,
                    LocationName = "Lang Thuong",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Cát Linh
                new Location
                {
                    Id = 101,
                    LocationName = "Cat Linh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Nam Đồng
                new Location
                {
                    Id = 102,
                    LocationName = "Nam Dong",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                // Phường Ô Chợ Dừa
                new Location
                {
                    Id = 103,
                    LocationName = "O Cho Dua",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Trung Tự
                new Location
                {
                    Id = 104,
                    LocationName = "Trung Tu",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Văn Miếu
                new Location
                {
                    Id = 105,
                    LocationName = "Van Mieu",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Văn Chương
                new Location
                {
                    Id = 106,
                    LocationName = "Van Chuong",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Trung Phụng
                new Location
                {
                    Id = 107,
                    LocationName = "Trung Phung",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Quốc Tử Giám
                new Location
                {
                    Id = 108,
                    LocationName = "Quoc Tu Giam",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Nguyễn Trãi
                new Location
                {
                    Id = 109,
                    LocationName = "Nguyen Trai",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Thổ Quan
                new Location
                {
                    Id = 110,
                    LocationName = "Tho Quan",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Phương Mai
                new Location
                {
                    Id = 111,
                    LocationName = "Phuong Mai",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Khâm Thiên
                new Location
                {
                    Id = 112,
                    LocationName = "Kham Thien",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                // Phường Trung Liệt
                new Location
                {
                    Id = 113,
                    LocationName = "Trung Liet",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 61,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                //wards of hai ba trung 62
                // Phường Bạch Đằng
                new Location
                {
                    Id = 114,
                    LocationName = "Bach Dang",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Bách Khoa
                new Location
                {
                    Id = 115,
                    LocationName = "Bach Khoa",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Bạch Mai
                new Location
                {
                    Id = 116,
                    LocationName = "Bach Mai",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Bùi Thị Xuân
                new Location
                {
                    Id = 117,
                    LocationName = "Bui Thi Xuan",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Cầu Dền
                new Location
                {
                    Id = 118,
                    LocationName = "Cau Den",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Đống Mác
                new Location
                {
                    Id = 119,
                    LocationName = "Dong Mac",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Đồng Nhân
                new Location
                {
                    Id = 120,
                    LocationName = "Dong Nhan",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Đồng Tâm
                new Location
                {
                    Id = 121,
                    LocationName = "Dong Tam",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Lê Đại Hành
                new Location
                {
                    Id = 122,
                    LocationName = "Le Dai Hanh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Minh Khai
                new Location
                {
                    Id = 123,
                    LocationName = "Minh Khai",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Ngô Thì Nhậm
                new Location
                {
                    Id = 124,
                    LocationName = "Ngo Thi Nham",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                // Phường Nguyễn Du
                new Location
                {
                    Id = 125,
                    LocationName = "Nguyen Du",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Phạm Đình Hổ
                new Location
                {
                    Id = 126,
                    LocationName = "Pham Dinh Ho",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Phố Huế
                new Location
                {
                    Id = 127,
                    LocationName = "Pho Hue",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Quỳnh Lôi
                new Location
                {
                    Id = 128,
                    LocationName = "Quynh Loi",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Quỳnh Mai
                new Location
                {
                    Id = 129,
                    LocationName = "Quynh Mai",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Thanh Lương
                new Location
                {
                    Id = 130,
                    LocationName = "Thanh Luong",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Thanh Nhàn
                new Location
                {
                    Id = 131,
                    LocationName = "Thanh Nhan",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },

                // Phường Trương Định
                new Location
                {
                    Id = 132,
                    LocationName = "Truong Dinh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                // Phường Vĩnh Tuy
                new Location
                {
                    Id = 133,
                    LocationName = "Vinh Tuy",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 62,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                 //Binh duong city
                 new Location
                 {
                     Id = 134,
                     LocationName = "Binh Duong",
                     PostalCode = "750000",
                     LocationLevel = ELocationLevel.Province,
                     LocationOf = null,
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                     Status = EStatusData.Active
                 },
                 //districts of binh duong
                 new Location
                 {
                     Id = 135,
                     LocationName = "Thanh pho Thu Dau Mot",
                     PostalCode = "75100",
                     LocationLevel = ELocationLevel.District,
                     LocationOf = 134,
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                     Status = EStatusData.Active
                 },
                new Location
                {
                    Id = 136,
                    LocationName = "Thanh pho Di An",
                    PostalCode = "75300",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 134,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 137,
                    LocationName = "Thanh pho Thuan An",
                    PostalCode = "75200",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 134,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 138,
                    LocationName = "Huyen Bau Bang",
                    PostalCode = "75700",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 134,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 139,
                    LocationName = "Huyen Dau Tieng",
                    PostalCode = "75800",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 134,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 140,
                    LocationName = "Huyen Bac Tan Uyen",
                    PostalCode = "75500",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 134,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 141,
                    LocationName = "Thi xa Phu Giao",
                    PostalCode = "75600",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 134,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 142,
                    LocationName = "Thi xa Ben Cat",
                    PostalCode = "75900",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 134,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 143,
                    LocationName = "Thi xa Tan Uyen",
                    PostalCode = "75400",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 134,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                // wards of Thanh pho Thu Dau Mot 135
                new Location
                {
                    Id = 144,
                    LocationName = "Chanh My",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 135,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 145,
                    LocationName = "Chanh Nghia",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 135,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 146,
                    LocationName = "Dinh Hoa",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 135,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 147,
                    LocationName = "Hiep An",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 135,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 148,
                    LocationName = "Hiep Thanh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 135,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 149,
                    LocationName = "Hoa Phu",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 135,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 150,
                    LocationName = "Phu Cuong",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 135,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 151,
                    LocationName = "Phu Hoa",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 135,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 152,
                    LocationName = "Phu Loi",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 135,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 153,
                    LocationName = "Phu My",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 135,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 154,
                    LocationName = "Phu Tan",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 135,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 155,
                    LocationName = "Phu Tho",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 135,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 156,
                    LocationName = "Tan An",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 135,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 157,
                    LocationName = "Tuong Binh Hiep",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 135,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                //wards of Thanh pho Di An 136
                new Location
                {
                    Id = 158,
                    LocationName = "Binh Minh 1",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 136,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 159,
                    LocationName = "Binh Minh 2",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 136,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 160,
                    LocationName = "Dong Tan",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 136,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 161,
                    LocationName = "Nhi Dong 1",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 136,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 162,
                    LocationName = "Nhi Dong 2",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 136,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 163,
                    LocationName = "Thang Loi 1",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 136,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 164,
                    LocationName = "Thang Loi 2",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 136,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 165,
                    LocationName = "Thong Nhat 1",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 136,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 166,
                    LocationName = "Thong Nhat 2",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 136,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
            // wards of Thuan an 137
            new Location
            {
                Id = 167,
                LocationName = "An Phu",
                PostalCode = null,
                LocationLevel = ELocationLevel.Ward,
                LocationOf = 137,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Status = EStatusData.Active
            },
                new Location
                {
                    Id = 168,
                    LocationName = "An Thanh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 137,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 169,
                    LocationName = "Binh Chuan",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 137,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 170,
                    LocationName = "Binh Hoa",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 137,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 171,
                    LocationName = "Binh Nham",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 137,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 172,
                    LocationName = "Hung Dinh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 137,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 173,
                    LocationName = "Lai Thieu",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 137,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 174,
                    LocationName = "Thuan Giao",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 137,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 175,
                    LocationName = "Vinh Phu",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 137,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 176,
                    LocationName = "An Son",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 137,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                 // Long An province
                 new Location
                 {
                     Id = 177,
                     LocationName = "Long An",
                     PostalCode = "850000",
                     LocationLevel = ELocationLevel.Province,
                     LocationOf = null,
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                     Status = EStatusData.Active
                 },
                 //list districs of long an
                 new Location
                 {
                     Id = 178,
                     LocationName = "Thanh pho Tan An",
                     PostalCode = "851000",
                     LocationLevel = ELocationLevel.District,
                     LocationOf = 177,
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                     Status = EStatusData.Active
                 },
                new Location
                {
                    Id = 179,
                    LocationName = "Thi xa Kien Tuong",
                    PostalCode = "855600",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 177,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 180,
                    LocationName = "Huyen Ben Luc",
                    PostalCode = "852340",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 177,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 181,
                    LocationName = "Huyen Can Duoc",
                    PostalCode = "852700",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 177,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 182,
                    LocationName = "Huyen Can Giuoc",
                    PostalCode = "853290",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 177,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 183,
                    LocationName = "Huyen Chau Thanh",
                    PostalCode = "82200",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 177,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 184,
                    LocationName = "Huyen Duc Hoa",
                    PostalCode = "853700",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 177,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 185,
                    LocationName = "Huyen Duc Hue",
                    PostalCode = "854241",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 177,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 186,
                    LocationName = "Huyen Moc Hoa",
                    PostalCode = "856000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 177,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 187,
                    LocationName = "Huyen Tan Hung",
                    PostalCode = "854700",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 177,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 188,
                    LocationName = "Huyen Tan Thanh",
                    PostalCode = "855100",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 177,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 189,
                    LocationName = "Huyen Tan Tru",
                    PostalCode = "851500",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 177,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 190,
                    LocationName = "Huyen Thanh Hoa",
                    PostalCode = "856400",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 177,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 191,
                    LocationName = "Huyen Thu Thua",
                    PostalCode = "853900",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 177,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 192,
                    LocationName = "Huyen Vinh Hung",
                    PostalCode = "856800",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 177,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                 // wards of Tan An
                 new Location
                 {
                     Id = 193,
                     LocationName = "Phuong 1",
                     PostalCode = null,
                     LocationLevel = ELocationLevel.Ward,
                     LocationOf = 178,
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                     Status = EStatusData.Active
                 },
                new Location
                {
                    Id = 194,
                    LocationName = "Phuong 2",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 178,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                // Continue for Phường 3 to Phường 7
                new Location
                {
                    Id = 200,
                    LocationName = "Khanh Hau",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 178,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 201,
                    LocationName = "Tan Khanh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 178,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 202,
                    LocationName = "Binh Tam",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 178,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 203,
                    LocationName = "Loi Binh Nhon",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 178,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 204,
                    LocationName = "An Vinh Ngai",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 178,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 205,
                    LocationName = "Huong Tho Phu",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 178,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 206,
                    LocationName = "Nhon Thanh Trung",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 178,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                //ward of kien tuong
                new Location
                {
                    Id = 207,
                    LocationName = "Phuong 1",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 179,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 208,
                    LocationName = "Phuong 2",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 179,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 209,
                    LocationName = "Phuong 3",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 179,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 210,
                    LocationName = "Binh Hiep",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 179,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 211,
                    LocationName = "Binh Tan",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 179,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 212,
                    LocationName = "Thanh Hung",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 179,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 213,
                    LocationName = "Thanh Tri",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 179,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 214,
                    LocationName = "Tuyen Thanh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 179,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                //ward of ben luc
                new Location
                {
                    Id = 215,
                    LocationName = "Thi tran Ben Luc",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 216,
                    LocationName = "An Thanh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 217,
                    LocationName = "Binh Duc",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                // Continue with other locations...
                new Location
                {
                    Id = 218,
                    LocationName = "Long Hiep",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 219,
                    LocationName = "Luong Binh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 220,
                    LocationName = "Luong Hoa",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 221,
                    LocationName = "My Yen",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 222,
                    LocationName = "Nhut Chanh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 223,
                    LocationName = "Phuoc Loi",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 224,
                    LocationName = "Tan Buu",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 225,
                    LocationName = "Tan Hoa",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 226,
                    LocationName = "Thanh Duc",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 227,
                    LocationName = "Thanh Hoa",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 228,
                    LocationName = "Thanh Loi",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 229,
                    LocationName = "Thanh Phu",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 180,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                //Da lat province
                new Location
                {
                    Id = 230,
                    LocationName = "Lam Dong",
                    PostalCode = "670000",
                    LocationLevel = ELocationLevel.Province,
                    LocationOf = null,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                 //list district of lamdong
                 new Location
                 {
                     Id = 231,
                     LocationName = "Thanh pho Da Lat",
                     PostalCode = "670000",
                     LocationLevel = ELocationLevel.District,
                     LocationOf = 230,
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                     Status = EStatusData.Active
                 },
                new Location
                {
                    Id = 232,
                    LocationName = "Thanh pho Bao Loc",
                    PostalCode = "671000",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 230,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 233,
                    LocationName = "Huyen Bao Lam",
                    PostalCode = "672010",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 230,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 234,
                    LocationName = "Huyen Cat Tien",
                    PostalCode = "672020",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 230,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 235,
                    LocationName = "Huyen Di Linh",
                    PostalCode = "672030",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 230,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 236,
                    LocationName = "Huyen Lam Ha",
                    PostalCode = "672040",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 230,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 237,
                    LocationName = "Huyen Lac Duong",
                    PostalCode = "672050",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 230,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 238,
                    LocationName = "Huyen Dam Rong",
                    PostalCode = "672060",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 230,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 239,
                    LocationName = "Huyen Don Duong",
                    PostalCode = "672070",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 230,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 240,
                    LocationName = "Huyen Da Huoai",
                    PostalCode = "672080",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 230,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 241,
                    LocationName = "Huyen Da Teh",
                    PostalCode = "672090",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 230,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 242,
                    LocationName = "Huyen Duc Trong",
                    PostalCode = "672100",
                    LocationLevel = ELocationLevel.District,
                    LocationOf = 230,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                //wards of hanh pho Da Lat 231
                new Location
                {
                    Id = 243,
                    LocationName = "Phuong 1",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 244,
                    LocationName = "Phuong 2",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 245,
                    LocationName = "Phuong 3",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 246,
                    LocationName = "Phuong 4",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 247,
                    LocationName = "Phuong 5",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 248,
                    LocationName = "Phuong 6",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 249,
                    LocationName = "Phuong 7",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 250,
                    LocationName = "Phuong 8",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 251,
                    LocationName = "Phuong 9",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 252,
                    LocationName = "Phuong 10",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 253,
                    LocationName = "Phuong 11",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 254,
                    LocationName = "Phuong 12",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 255,
                    LocationName = "Ta Nung",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 256,
                    LocationName = "Tram Hanh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 257,
                    LocationName = "Xuan Tho",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 258,
                    LocationName = "Xuan Truong",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 231,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                //wards of 232
                new Location
                {
                    Id = 259,
                    LocationName = "B'Lao",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 232,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 260,
                    LocationName = "Phuong 1",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 232,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 261,
                    LocationName = "Phuong 2",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 232,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 262,
                    LocationName = "Loc Phat",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 232,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 263,
                    LocationName = "Loc Tien",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 232,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 264,
                    LocationName = "Loc Son",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 232,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 265,
                    LocationName = "Loc Nga",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 232,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 266,
                    LocationName = "Loc Chau",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 232,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 267,
                    LocationName = "Dam Bri",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 232,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 268,
                    LocationName = "Loc Thanh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 232,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 269,
                    LocationName = "Dai Lao",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 232,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                // ward of 233
                new Location
                {
                    Id = 270,
                    LocationName = "Loc Thang",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 233,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 271,
                    LocationName = "B'La",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 233,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 272,
                    LocationName = "Loc An",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 233,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 273,
                    LocationName = "Loc Bac",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 233,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 274,
                    LocationName = "Loc Bao",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 233,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 275,
                    LocationName = "Loc Duc",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 233,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 276,
                    LocationName = "Loc Lam",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 233,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 277,
                    LocationName = "Loc Nam",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 233,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 278,
                    LocationName = "Loc Ngai",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 233,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 279,
                    LocationName = "Loc Phu",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 233,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 280,
                    LocationName = "Loc Quang",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 233,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 281,
                    LocationName = "Loc Tan",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 233,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 282,
                    LocationName = "Loc Thanh",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 233,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                },
                new Location
                {
                    Id = 283,
                    LocationName = "Tan Lac",
                    PostalCode = null,
                    LocationLevel = ELocationLevel.Ward,
                    LocationOf = 233,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Status = EStatusData.Active
                }
            );
        }
    }
}