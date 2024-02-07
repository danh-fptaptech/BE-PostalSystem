﻿using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Models.DTOs.req.Location
{
    public class RDTOLocationWard
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string PostalCode { get; set; }
        public ELocationLevel LocationLevel { get; set; }
        public int? LocationOf { get; set; }
        public EStatusData Status { get; set; }
    }
}
