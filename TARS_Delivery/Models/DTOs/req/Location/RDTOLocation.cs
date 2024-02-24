using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.DTOs.req.Location
{
    public class RDTOLocation
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string PostalCode { get; set; }
        public ELocationLevel LocationLevel { get; set; }
        public int? LocationOf { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public EStatusData Status { get; set; }
    }
}
