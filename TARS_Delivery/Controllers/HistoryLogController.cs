using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.DTOs.req.HistoryLog;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;
using TARS_Delivery.Services;
using TARS_Delivery.Services.imp;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryLogController : ControllerBase
    {
        private readonly IHistoryLogService _historyLogService;

        public HistoryLogController(IHistoryLogService historyLogService)
        {
            _historyLogService = historyLogService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListHistoryLogDTO>>> GetAllHistoryLogs()
        {
            return Ok(await _historyLogService.GetAllHistoryLogs());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HistoryLog>> GetHistoryLogById(int id)
        {
            var historyLog = await _historyLogService.GetHistoryLogById(id);
            if (historyLog == null)
            {
                return NotFound();
            }
            return Ok(historyLog);
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

        //[HttpPut("{id}/step")]
        //public async Task<IActionResult> UpdateStep(int id, EPackageStatus newStep)
        //{
        //    try
        //    {
        //        await _historyLogService.UpdateStep(id, newStep);
        //        return Ok();
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

        /*[HttpPut("{id}/processstep")]
        public async Task<IActionResult> UpdateProcessStep(int id, EStep newProcessStep)
        {
            await _historyLogService.UpdateProcessStep(id, newProcessStep);
            return Ok();
        }*/
    }
}
