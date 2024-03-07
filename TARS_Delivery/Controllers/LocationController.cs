using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req.Location;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;
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
        //Get all Locations
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
        //Get Location by Id
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
        //Add Location
        [HttpPost]
        public async Task<ActionResult> AddLocation(Location location)
        {
            if (ModelState.IsValid)
            {
                var checkPostalCode = await _iLocationRepository.GetLocationByCode(location.PostalCode);
                if (checkPostalCode != null)
                {
                    return BadRequest("Postal code already exists");
                }
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
        //Update Location
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateLocation(Location location)
        {
            if (ModelState.IsValid)
            {
                var checkPostalCode = await _iLocationRepository.GetLocationByCode(location.PostalCode);
                if (checkPostalCode != null)
                {
                    if (checkPostalCode.Id != location.Id)
                    {
                        return BadRequest("Postal code already exists");
                    }
                }
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
        //Change Status
        [HttpGet("ChangeStatus/{id}")]
        public async Task<ActionResult> UpdateStatus(int id)
        {
            try
            {
                await _iLocationRepository.UpdateStatus(id);
                return Ok("Update successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //Get Child Location
        [HttpGet("GetChildLocation/{id}")]
        public async Task<ActionResult> GetChildLocation(int id)
        {
            try
            {
                var location = await _iLocationRepository.GetChildLocation(id);

                if (location is RDTOLocationProvince)
                {
                    var countryChild = (RDTOLocationProvince)location;
                    return Ok(countryChild);
                }
                else if (location is RDTOLocationDistric)
                {
                    var districChild = (RDTOLocationDistric)location;
                    return Ok(districChild);
                }
                else if (location is RDTOLocationWard)
                {
                    var districChild = (RDTOLocationWard)location;
                    return Ok(districChild);
                }
                else
                {
                    return Ok(location);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //Get List Location By Level
        [HttpGet("GetListLocationByLevel/{eLocationLevel}")]
        public async Task<ActionResult<List<RDTOLocation>>> GetListLocationByLevel(string eLocationLevel)
        {
            try
            {
                switch (eLocationLevel.ToLower())
                {
                    case "province":
                        var province = await _iLocationRepository.GetListLocationByLevel(ELocationLevel.Province);
                        return Ok(province);
                    case "district":
                        var distric = await _iLocationRepository.GetListLocationByLevel(ELocationLevel.District);
                        return Ok(distric);
                    case "ward":
                        var ward = await _iLocationRepository.GetListLocationByLevel(ELocationLevel.Ward);
                        return Ok(ward);
                    default:
                        return NotFound("Please choice [Province,District,Ward]");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
        //Get Location by ZipCode
        [HttpGet("GetLocationByZipCode/{zipCode}")]
        public async Task<ActionResult> GetLocationByZipCode(string zipCode)
        {
            try
            {
                var location = await _iLocationRepository.GetLocationByCode(zipCode);
                if (location != null)
                {
                    return Ok(location);
                }
                else
                {
                    return NotFound("Location not found");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
