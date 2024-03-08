using TARS_Delivery.Models.DTOs.req.Item;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<IEnumerable<ListItemDTO>> GetAllItems()
        {
            return await _itemRepository.GetAllItems();
        }

        public async Task<Item> GetItemById(int id)
        {
            return await _itemRepository.GetItemById(id);
        }

        public async Task<Item> AddItem(Item item)
        {
            return await _itemRepository.AddItem(item);
        }

        public async Task<Item> UpdateItem(int id, ItemUpdateDTO item)
        {
            return await _itemRepository.UpdateItem(id, item);
        }

        public void ChangeStatusItem(int id, int status)
        {
            _itemRepository.ChangeStatusItem(id, status);
        }

        public async Task<bool> ItemExists(int id)
        {
            return await _itemRepository.ItemExists(id);
        }
    }
}
