using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.DTOs.req.Location
{
    public class RDTOLocationByZipcode
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public int PostalCode { get; set; }
        public ELocationLevel LocationLevel { get; set; }
        public string LocationLevelString { get; set; }
        public int? LocationOf { get; set; }
        public string? LocationOfString { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public EStatusData Status { get; set; }
    }
}
