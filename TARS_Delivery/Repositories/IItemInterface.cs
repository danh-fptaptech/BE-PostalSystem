﻿using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories
{
    public interface IItemInterface
    {
        Task<IEnumerable<ListItemDTO>> GetAllItems();
        Task<Item> GetItemById(int id);
        Task<Item> AddItem(ItemCreateDTO item);
        Task<Item> UpdateItem(int id, ItemUpdateDTO item);
        void ChangeStatusItem(int id, int status);
        //check if item exists
        Task<bool> ItemExists(int id);
    }
}
