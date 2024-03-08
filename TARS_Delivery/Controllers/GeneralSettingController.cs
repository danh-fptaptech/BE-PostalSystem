using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services;

namespace TARS_Delivery.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GeneralSettingController : ControllerBase
{
    private readonly IGeneralSettingService _generalSettingService;
    
    public GeneralSettingController(IGeneralSettingService generalSettingService)
    {
        _generalSettingService = generalSettingService;
    }

    [HttpGet]
    [Route("getAllSettings")]
    public async Task<ActionResult<List<GeneralSetting>>> GetAllSettings()
    {
        return await _generalSettingService.GetAllSettings();
    }

    [HttpGet]
    [Route("getSettingByName")]
    public async Task<ActionResult<GeneralSetting>> GetSettingByName(string name)
    {
        return await _generalSettingService.GetSettingByName(name);
    }

    [HttpPut]
    [Route("updateSetting")]
    public async Task<ActionResult> UpdateSetting(RDTOGeneralSetting setting)
    {
        foreach(var s in setting.Settings)
        {
          await _generalSettingService.UpdateSetting(s.SettingName, s.SettingValue);
        }
        return Ok(new {message="Update successfuly!"});
        
    }

    [HttpGet]
    [Route("getSettingValue")]
    public async Task<string> GetSettingValue(string name)
    {
        return await _generalSettingService.GetSettingValue(name);
    }
}