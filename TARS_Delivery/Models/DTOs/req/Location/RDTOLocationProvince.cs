using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Models.DTOs.req.Location
{
    public class RDTOLocationProvince
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public int PostalCode { get; set; }
        public ELocationLevel LocationLevel { get; set; }
        public int? LocationOf { get; set; }
        public EStatusData Status { get; set; }
        public List<RDTOLocationCity>? cities { get; set; }
    }
}
