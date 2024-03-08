namespace TARS_Delivery.Models.DTOs.req
{
    public class RDTOGeneralSetting
    {
        public ICollection<RDTOGeneralSettingUpdate> Settings { get; set; }
    }

    public class RDTOGeneralSettingUpdate
    {
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
    }
}
