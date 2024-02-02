using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req.Location;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationRepository _iLocationRepository;
        public LocationController(ILocationRepository iLocationRepository)
        {
            _iLocationRepository = iLocationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLocations()
        {
            try
            {
                var locations = await _iLocationRepository.GetAllLocations();
                return Ok(locations);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocationById(int id)
        {
            try
            {
                var location = await _iLocationRepository.GetLocationById(id);
                return Ok(location);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult> AddLocation(Location location)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _iLocationRepository.AddLocation(location);
                    return Ok(location);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateLocation(Location location)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _iLocationRepository.UpdateLocation(location.Id, location);
                    return Ok(location);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteLocation(int id)
        {
            try
            {
                await _iLocationRepository.DeleteLocation(id);
                return Ok("Delete successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPut("ChangeStatus/{id}")]
        public async Task<ActionResult> UpdateStatus(int id)
        {
            try
            {
                await _iLocationRepository.UpdateStatus(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("GetChildLocation/{id}")]
        public async Task<ActionResult> GetChildLocation(int id)
        {
            try
            {
                var location = await _iLocationRepository.GetChildLocation(id);

                if (location is RDTOLocationCountry)
                {
                    var countryChild = (RDTOLocationCountry)location;
                    // Xử lý khi là RDTOLocationCountry
                    return Ok(countryChild);
                }
                else if (location is RDTOLocationProvince)
                {
                    var provinceChild = (RDTOLocationProvince)location;
                    // Xử lý khi là RDTOLocationProvince
                    return Ok(provinceChild);
                }
                else if (location is RDTOLocationCity)
                {
                    var cityChild = (RDTOLocationCity)location;
                    // Xử lý khi là RDTOLocationCity
                    return Ok(cityChild);
                }
                else if (location is RDTOLocationDistric)
                {
                    var districChild = (RDTOLocationDistric)location;
                    // Xử lý khi là RDTOLocationDistric
                    return Ok(districChild);
                }
                else
                {
                    // Xử lý khi là đối tượng không xác định
                    return Ok(location);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("GetListLocationByLevel/{eLocationLevel}")]
        public async Task<ActionResult> GetListLocationByLevel()
        {
            return Ok();
        }
    }
}
