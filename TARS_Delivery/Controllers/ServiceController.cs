using Microsoft.AspNetCore.Mvc;
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
        //Get all Services
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
        //Get Service by Id
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
        //Add Service
        [HttpPost]
        public async Task<IActionResult> AddService(Service service)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var newService = await _iServiceRepository.CreateService(service);
                    return Ok(newService);
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
        //Update Service
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
        //change status
        [HttpGet("/api/ChangeStatusService/{id}")]
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
        //Get Services by Weight
        [HttpGet("/GetServicesByWeight/{weight}")]
        public async Task<IActionResult> GetServicesByWeight(int weight)
        {
            try
            {
                var services = await _iServiceRepository.GetServicesByWeight(weight);
                if (services.Count == 0)
                {
                    return NotFound("No services found");
                }
                return Ok(services);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //Validate Weight
        [HttpGet("/api/ValidateServiceWeight/{serviceTypeId}/{weightFrom}/{weightTo}/{serviceId}")]
        public async Task<IActionResult> ValidateWeight(int serviceTypeId,int weightFrom, int weightTo,int serviceId)
        {
            try
            {
                var result = await _iServiceRepository.ValidateWeight(serviceTypeId, weightFrom, weightTo, serviceId);
                if (result.Count==0)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //Allow Range
        [HttpGet("/api/AllowRange/{serviceTypeId}")]
        public async Task<IActionResult> AlowRange(int serviceTypeId)
        {
            try
            {
                var result = await _iServiceRepository.AlowRange(serviceTypeId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
