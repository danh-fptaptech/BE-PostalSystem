using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req.Item;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Repositories.imp
{
    public class ItemRepository : IItemRepository
    {
        private readonly DatabaseContext _context;
        public ItemRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ListItemDTO>> GetAllItems()
        {
            return await _context.Items
                .Select(x => new ListItemDTO
                {
                    Id = x.Id,
                    PackageId = x.PackageId,
                    ItemName = x.ItemName,
                    ItemWeight = x.ItemWeight,
                    ItemQuantity = x.ItemQuantity,
                    ItemValue = x.ItemValue,
                    CreatedAt = (DateTime)x.CreatedAt,
                    UpdatedAt = (DateTime)x.UpdatedAt,
                    Status = x.Status
                })
                .ToListAsync();
        }

        public async Task<Item> GetItemById(int id)
        {
            return await _context.Items
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<Item> AddItem(Item item)
        {
            await _context.Items.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<Item> UpdateItem(int id, ItemUpdateDTO item)
        {
            var itemToUpdate = await _context.Items
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            itemToUpdate!.ItemName = item.ItemName;
            itemToUpdate.ItemWeight = item.ItemWeight;
            itemToUpdate.ItemQuantity = item.ItemQuantity;
            itemToUpdate.ItemValue = item.ItemValue;
            itemToUpdate.UpdatedAt = DateTime.Now;
            await _context.SaveChangesAsync();
            return itemToUpdate;
        }

        public void ChangeStatusItem(int id, int status)
        {
            var item = _context.Items
                .Where(x => x.Id == id)
                .FirstOrDefault();
            item.Status = (EStatusData)status;
            _context.SaveChanges();
        }

        public async Task<bool> ItemExists(int id)
        {
            return await _context.Items
                .AnyAsync(x => x.Id == id);
        }
    }
}
