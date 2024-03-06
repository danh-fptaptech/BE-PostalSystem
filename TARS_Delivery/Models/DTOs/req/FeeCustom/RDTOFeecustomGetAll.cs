using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.DTOs.req.FeeCustom
{
    public class RDTOFeecustomGetAll
    {
        public int Id { get; set; }
        public string? LocationFromName { get; set; }
        public string? LocationToName { get; set; }
        public int ServiceId { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceDescription { get; set; }
        public int WeighFrom { get; set; }
        public int WeighTo { get; set; }
        public decimal? OverWeightCharge { get; set; }
        public decimal FeeCharge { get; set; }
        public int TimeProcess { get; set; }
        public EStatusData Status { get; set; }
    }
}
