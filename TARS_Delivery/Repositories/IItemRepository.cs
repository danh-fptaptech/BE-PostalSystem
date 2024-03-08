using TARS_Delivery.Models.DTOs.req.Item;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories
{
    public interface IItemRepository
    {
        Task<IEnumerable<ListItemDTO>> GetAllItems();
        Task<Item> GetItemById(int id);
        Task<Item> AddItem(Item item);
        Task<Item> UpdateItem(int id, ItemUpdateDTO item);
        void ChangeStatusItem(int id, int status);
        //check if item exists
        Task<bool> ItemExists(int id);
    }
}
