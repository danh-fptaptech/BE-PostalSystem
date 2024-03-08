using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories;

public interface IGeneralSettingRepository
{
    public Task<List<GeneralSetting>> GetAllSettings();
    public Task<GeneralSetting> GetSettingByName(string name);
    public Task<GeneralSetting> UpdateSetting(string name, string value);
}