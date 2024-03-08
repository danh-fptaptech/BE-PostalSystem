using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req.Item;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListItemDTO>>> GetAllItems()
        {
            var items = await _itemService.GetAllItems();
            return Ok(items);
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

        [HttpPut("{id}/status/{status}")]
        public IActionResult ChangeStatusItem(int id, int status)
        {
            _itemService.ChangeStatusItem(id, status);
            return NoContent();
        }
    }
}
