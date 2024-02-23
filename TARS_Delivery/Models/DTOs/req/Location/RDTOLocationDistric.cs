﻿using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.DTOs.req.Location
{
    public class RDTOLocationDistric
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string PostalCode { get; set; }
        public ELocationLevel LocationLevel { get; set; }
        public int? LocationOf { get; set; }
        public EStatusData Status { get; set; }
        public List<RDTOLocationWard>? Wards { get; set; }
    }
}
