using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories;

public interface IGeneralSettingRepository
{
    public Task<GeneralSetting> GetSettingByName(string name);
    public Task<bool> UpdateSetting(string name, string value);
}