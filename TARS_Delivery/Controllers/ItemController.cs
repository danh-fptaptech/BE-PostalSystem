using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.DTOs.req.Item;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services.imp;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ItemService _itemService;
        public ItemController(ItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListItemDTO>>> GetAllItems()
        {
            return Ok(await _itemService.GetAllItems());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItemById(int id)
        {
            var item = await _itemService.GetItemById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<Item>> AddItem(ItemCreateDTO item)
        {
            try
            {
                var newItem = await _itemService.AddItem(item);
                return CreatedAtAction("GetItemById", new { id = newItem.Id }, newItem);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, ItemUpdateDTO item)
        {
            try
            {
                await _itemService.UpdateItem(id, item);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _itemService.ItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpPut("{id}/status/{status}")]
        public async Task<IActionResult> ChangeStatusItem(int id, int status)
        {
            try
            {
                _itemService.ChangeStatusItem(id, status);
                return Ok();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _itemService.ItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

    }
}
