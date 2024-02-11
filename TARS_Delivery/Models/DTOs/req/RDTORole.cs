using System.ComponentModel.DataAnnotations;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Models.DTOs.req
{
    public class RDTORole
    {
        [Required(ErrorMessage = "The role name is required.")]
        public string RoleName { get; set; }
        public EStatusData Status { get; set; }
    }
}
