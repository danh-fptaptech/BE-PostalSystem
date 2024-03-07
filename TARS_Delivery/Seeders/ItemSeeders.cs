using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders
{
    public class ItemSeeders
    {
        public ItemSeeders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
            new Item
            {
                Id = 1,
                PackageId = 1,
                ItemName = "Quần áo",
                ItemWeight = 2,
                ItemQuantity = 5,
                ItemValue = 1000000,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Status = Models.Enums.EStatusData.Active
            },
            new Item
            {
                Id = 2,
                PackageId = 2,
                ItemName = "Giày dép",
                ItemWeight = 1,
                ItemQuantity = 3,
                ItemValue = 500000,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Status = Models.Enums.EStatusData.Active
            });
        }
    }
}
