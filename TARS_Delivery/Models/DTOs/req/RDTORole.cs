using System.ComponentModel.DataAnnotations;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.DTOs.req
{
    public class RDTORole
    {
        public string Name { get; set; }
        public EStatusData Status { get; set; }
    }
}
