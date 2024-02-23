﻿using TARS_Delivery.Models.DTOs.req.Item;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services
{
    public interface IItemService
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
