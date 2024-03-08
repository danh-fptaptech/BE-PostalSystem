using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupportTicketController : ControllerBase
    {
        private readonly ISupportTicketService supportTicketService;
        public SupportTicketController(ISupportTicketService supportTicketService)
        {
            this.supportTicketService = supportTicketService;
        }

        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<List<RDTOSupportTicket>>> GetAllSupportTickets()
        {
            try
            {
                return Ok(await supportTicketService.GetAllSupportTicketsAsync());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public async Task<ActionResult<SupportTicket>> GetSupportTicketById(int id)
        {
            SupportTicket supportTicket = await supportTicketService.GetSupportTicketByIdAsync(id);
            if (supportTicket == null)
            {
                return NotFound();
            }
            return Ok(supportTicket);
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<SupportTicket>> CreateSupportTicket(RDTOSupportTicket supportTicket)
        {
            try
            {
                return Ok(await supportTicketService.CreateSupportTicketAsync(supportTicket));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("update/{id}")]
        public async Task<ActionResult<SupportTicket>> UpdateSupportTicket(int id, SupportTicket supportTicket)
        {
            try
            {
                return Ok(await supportTicketService.UpdateSupportTicketAsync(id, supportTicket));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<ActionResult<SupportTicket>> DeleteSupportTicket(int id)
        {
            try
            {
                return Ok(await supportTicketService.DeleteSupportTicketAsync(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
