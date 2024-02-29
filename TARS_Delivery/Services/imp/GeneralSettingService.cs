using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp;

public class GeneralSettingService: IGeneralSettingService
{   
    private readonly IGeneralSettingRepository _rp;
    
    public GeneralSettingService(IGeneralSettingRepository rp)
    {
        _rp = rp;
    }
    
    public async Task<GeneralSetting> GetSettingByName(string name)
    {
        return await _rp.GetSettingByName(name);
    }

    public async Task<ActionResult> UpdateSetting(string name, string value)
    {
        try
        {
            if (await _rp.UpdateSetting(name, value))
            {
                return new OkResult();
            }
            return  new BadRequestObjectResult("Setting "+name+" cannot be updated");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new BadRequestObjectResult("Setting "+name+" cannot be updated");
        }
    }

    public async Task<string> GetSettingValue(string name)
    {
        GeneralSetting setting = await _rp.GetSettingByName(name);
        if (setting == null)
        {
            throw new Exception($"Setting {name} not found");
        }
        return setting.SettingValue;
    }
}