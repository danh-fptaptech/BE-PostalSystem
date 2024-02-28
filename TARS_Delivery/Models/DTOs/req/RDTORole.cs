﻿using System.ComponentModel.DataAnnotations;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Models.DTOs.req
{
    public class RDTORole
    {
        public string Name { get; set; }
        public EStatusData Status { get; set; }
    }
}
