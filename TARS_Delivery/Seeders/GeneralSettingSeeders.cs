using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Seeders;

public class GeneralSettingSeeders
{
    public GeneralSettingSeeders(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GeneralSetting>().HasData(
            new GeneralSetting { Id = 1, SettingName = "site_name", SettingValue = "eProject TARS Delivery System"},
            new GeneralSetting { Id = 2, SettingName = "logo_site", SettingValue = "Value 2"},
            new GeneralSetting { Id = 3, SettingName = "logo_site_bg", SettingValue = "Value 3"},
            new GeneralSetting { Id = 4, SettingName = "location_ver", SettingValue = ""},
            new GeneralSetting { Id = 5, SettingName = "fee_custom_ver", SettingValue = ""}
        );
    }
}