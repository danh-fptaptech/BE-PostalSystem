using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp;

public class GeneralSettingRepository : IGeneralSettingRepository
{  
    private readonly DatabaseContext _db;
    
    public GeneralSettingRepository(DatabaseContext db)
    {
        _db = db;
    }
    
    public async Task<List<GeneralSetting>> GetAllSettings()
    {
        return await _db.GeneralSettings.ToListAsync();
    }

    public async Task<GeneralSetting> GetSettingByName(string name)
    {
        return await _db.GeneralSettings.FirstOrDefaultAsync(s => s.SettingName == name);
    }

    public async Task<GeneralSetting> GeneralSetting(string name, string value)
    {
        GeneralSetting setting = await _db.GeneralSettings.FirstOrDefaultAsync(s => s.SettingName == name);
        if (setting == null)
        {
            throw new Exception($"Setting {name} not found");
        }
        setting.SettingValue = value;
        await _db.SaveChangesAsync();
        return setting;
    }

    public async Task<GeneralSetting> UpdateSetting(string name, string value)
    {
        GeneralSetting setting = await _db.GeneralSettings.FirstOrDefaultAsync(s => s.SettingName == name);
        if (setting == null)
        {
            throw new Exception($"Setting {name} not found");
        }
        setting.SettingValue = value;
        await _db.SaveChangesAsync();
        return setting;
    }
}