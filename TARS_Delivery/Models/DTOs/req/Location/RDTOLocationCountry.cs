using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Models.DTOs.req.Location
{
    public class RDTOLocationCountry
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public int PostalCode { get; set; }
        public ELocationLevel LocationLevel { get; set; }
        public int? LocationOf { get; set; }
        public EStatusData Status { get; set; }
        public List<RDTOLocationProvince>? provinces { get; set; }
    }
}
