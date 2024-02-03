using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.DTOs.req.HistoryLog;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services.imp;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryLogController : ControllerBase
    {
        private readonly HistoryLogService _historyLogService;

        public HistoryLogController(HistoryLogService historyLogService)
        {
            _historyLogService = historyLogService;
        }

        [HttpGet]
        public async Task<IEnumerable<ListHistoryLogDTO>> GetAllHistoryLogs()
        {
            return await _historyLogService.GetAllHistoryLogs();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HistoryLog>> GetHistoryLogById(int id)
        {
            var historyLog = await _historyLogService.GetHistoryLogById(id);

            if (historyLog == null)
            {
                return NotFound();
            }

            return historyLog;
        }

        [HttpPost]
        public async Task<ActionResult<HistoryLog>> AddHistoryLog(ListHistoryLogDTO historyLog)
        {
            var newHistoryLog = await _historyLogService.AddHistoryLog(historyLog);

            return CreatedAtAction("GetHistoryLogById", new { id = newHistoryLog.Id }, newHistoryLog);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHistoryLog(int id, ListHistoryLogDTO historyLog)
        {
            if (id != historyLog.Id)
            {
                return BadRequest();
            }

            try
            {
                await _historyLogService.UpdateHistoryLog(id, historyLog);
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }

            return NoContent();
        }

        [HttpPut("{id}/status/{status}")]
        public IActionResult ChangeStatusHistoryLog(int id, int status)
        {
            _historyLogService.ChangeStatusHistoryLog(id, status);

            return NoContent();
        }
    }
}
