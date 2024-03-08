using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services;

public interface IGeneralSettingService
{
    public Task<List<GeneralSetting>> GetAllSettings();
    public Task<GeneralSetting> GetSettingByName(string name);
    public Task<ActionResult> UpdateSetting(string name, string value);
    public Task<string> GetSettingValue(string name);
}