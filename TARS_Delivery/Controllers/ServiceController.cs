﻿using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _iServiceRepository;

        public ServiceController(IServiceRepository iServiceRepository)
        {
            _iServiceRepository = iServiceRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Service>>> GetAllServices()
        {
            try
            {
                var services = await _iServiceRepository.GetAllServices();
                return Ok(services);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetServiceById(int id)
        {
            try
            {
                var service = await _iServiceRepository.GetServiceById(id);
 
                return Ok(service);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddService(Service service)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _iServiceRepository.CreateService(service);
                    return Ok("Service added successfully");
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                }
            }
            else
            {
                   return BadRequest("Invalid model state");
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(Service service)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _iServiceRepository.UpdateService(service.Id, service);
                    return Ok("Service updated successfully");
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                }
            }else
            {
                return BadRequest("Invalid model state");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            try
            {
                await _iServiceRepository.DeleteService(id);
                return Ok("Service deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //change status
        [HttpPut("/ChangeStatus/{id}")]
        public async Task<IActionResult> ChangeStatus(int id)
        {
            try
            {
                await _iServiceRepository.ChangeStatus(id);
                return Ok("Service status changed successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
