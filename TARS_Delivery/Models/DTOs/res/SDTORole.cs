﻿using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Models.DTOs.res
{
    public class SDTORole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<string>? RoleHasPermissions { get; set; }
        public EStatusData Status { get; set; }      
    }
}