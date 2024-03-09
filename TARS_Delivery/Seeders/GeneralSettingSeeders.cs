using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders;

public class GeneralSettingSeeders
{
    public GeneralSettingSeeders(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GeneralSetting>().HasData(
            new GeneralSetting { Id = 1, SettingName = "site_name", SettingValue = "eProject TARS Delivery System", Status = Models.Enums.EStatusData.Active},
            new GeneralSetting { Id = 2, SettingName = "site_title", SettingValue = "TARS Delivery", Status = Models.Enums.EStatusData.Active },
            new GeneralSetting { Id = 3, SettingName = "site_description", SettingValue = "Site description dummy", Status = Models.Enums.EStatusData.Active },
            new GeneralSetting { Id = 4, SettingName = "site_keywords", SettingValue = "Site keywords dummy" , Status = Models.Enums.EStatusData.Active },
            new GeneralSetting { Id = 5, SettingName = "site_author", SettingValue = "Site author dummy", Status = Models.Enums.EStatusData.Active },
            new GeneralSetting { Id = 6, SettingName = "site_email", SettingValue = "Site author dummy" , Status = Models.Enums.EStatusData.Active },
            new GeneralSetting { Id = 7, SettingName = "site_phone", SettingValue = "Site phone dummy" , Status = Models.Enums.EStatusData.Active },
            new GeneralSetting { Id = 8, SettingName = "site_address", SettingValue = "Site address dummy" , Status = Models.Enums.EStatusData.Active },
            new GeneralSetting { Id = 9, SettingName = "site_logo", SettingValue = "Site logo dummy" , Status = Models.Enums.EStatusData.Active },
            new GeneralSetting { Id = 10, SettingName = "site_favicon", SettingValue = "Site favicon dummy" , Status = Models.Enums.EStatusData.Active },
            new GeneralSetting { Id = 11, SettingName = "site_logo_bg", SettingValue = "Site logo bg dummy" , Status = Models.Enums.EStatusData.Active },
            new GeneralSetting { Id = 12, SettingName = "site_language", SettingValue = "Site language dummy" , Status = Models.Enums.EStatusData.Active },
            new GeneralSetting { Id = 13, SettingName = "site_favicon_bg", SettingValue = "Site favicon_bg dummy" , Status = Models.Enums.EStatusData.Active },
            new GeneralSetting { Id = 14, SettingName = "rateConvert", SettingValue = "5" , Status = Models.Enums.EStatusData.Active },
            new GeneralSetting { Id = 15, SettingName = "limitSize", SettingValue = "50" , Status = Models.Enums.EStatusData.Active },
            new GeneralSetting { Id = 16, SettingName = "limitWeight", SettingValue = "6" , Status = Models.Enums.EStatusData.Active }
        );
    }
}