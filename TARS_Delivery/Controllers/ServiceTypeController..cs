using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceTypeController : ControllerBase
    {
        private readonly IServiceTypeRepository _iServiceTypeRepository;
        public ServiceTypeController(IServiceTypeRepository iServiceTypeRepository)
        {
            _iServiceTypeRepository = iServiceTypeRepository;
        }
        //Get all ServiceTypes
        [HttpGet]
        public async Task<IActionResult> GetAllServiceTypes()
        {
            try
            {
                var serviceTypes = await _iServiceTypeRepository.GetAllServiceTypes();
                return Ok(serviceTypes);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //Get ServiceType by Id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetServiceTypeById(int id)
        {
            try
            {
                var serviceType = await _iServiceTypeRepository.GetServiceTypeById(id);
                return Ok(serviceType);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //Add ServiceType
        [HttpPost]
        public async Task<IActionResult> AddServiceType(TARS_Delivery.Models.Entities.ServiceType serviceType)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var newServiceType = await _iServiceTypeRepository.CreateServiceType(serviceType);
                    return Ok(newServiceType);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                }
            }
            return BadRequest();
        }
        //Update ServiceType
        [HttpPut]
        public async Task<IActionResult> UpdateServiceType(TARS_Delivery.Models.Entities.ServiceType serviceType)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var newServiceType = await _iServiceTypeRepository.UpdateServiceType(serviceType);
                    return Ok(newServiceType);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                }
            }
            return BadRequest();
        }
        //Change ServiceType status
        [HttpPut("{id}")]
        public async Task<IActionResult> ChangeStatus(int id)
        {
            try
            {
                var serviceType = await _iServiceTypeRepository.ChangeStatus(id);
                return Ok(serviceType);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //get child ServiceType by Id
        [HttpGet("GetChildServiceTypeById/{id}")]
        public async Task<IActionResult> GetChildServiceTypeById(int id)
        {
            try
            {
                var serviceType = await _iServiceTypeRepository.GetChildServiceTypeById(id);
                return Ok(serviceType);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //ChangeStatus
        [HttpGet("ChangeServiceTypeStatus/{id}")]
        public async Task<IActionResult> ChangeServiceTypeStatus(int id)
        {
            try
            {
                var serviceType = await _iServiceTypeRepository.ChangeStatus(id);
                return Ok(serviceType);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
