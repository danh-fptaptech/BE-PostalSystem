using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services;

namespace TARS_Delivery.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PackageController : ControllerBase
{
    private readonly IPackageService _packageService;
    
    public PackageController(IPackageService packageService)
    {
        _packageService = packageService;
    }

    #region Get all packages
    
    [HttpGet]
    [Route("all")]
    public async Task<ActionResult<ICollection<SDTOPackageList>>> GetAllPackages()
    {
        ICollection<SDTOPackageList> packages = await _packageService.GetAllPackages();
        if(packages.Count == 0)
        {
            return NoContent();
        }
        return Ok(packages);
    }
    #endregion
    
    #region Get a package by id
    
    [HttpGet]
    [Route("getbyid/{id}")]
    public async Task<ActionResult<Package>> GetPackageById(int id)
    {
        Package package = await _packageService.GetPackageById(id);
        if (package == null)
        {
            return NotFound();
        }
        return Ok(package);
    }
    #endregion

    #region Get a package by tracking number
    [HttpGet]
    [Route("getbytracking/{trackingNumber}")]
    public async Task<ActionResult<Package>> GetPackageByTrackingNumber(string trackingNumber)
    {
        Package package = await _packageService.GetPackageByTrackingNumber(trackingNumber);
        if (package == null)
        {
            return NotFound();
        }
        return Ok(package);
    }

    #endregion
    
    #region Create a new package by user
    [HttpPost]
    [Route("add")]
    public async Task<ActionResult<Package>> AddPackage(RDTOPackage package)
    {
        try
        {
            Package newPackage = await _packageService.UserAddPackage(package);
            return CreatedAtAction(nameof(GetPackageById), new { id = newPackage.Id }, newPackage);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    #endregion
    
}