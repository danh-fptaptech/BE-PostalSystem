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
    
    public async Task<GeneralSetting> GetSettingByName(string name)
    {
        return await _db.GeneralSettings.FindAsync(name);
    }

    public async Task<bool> UpdateSetting(string name, string value)
    {
        GeneralSetting setting = await _db.GeneralSettings.FindAsync(name);
        try
        {
            if (setting == null)
            {
                return false;
            }
            setting.SettingValue = value;
            await _db.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }
}