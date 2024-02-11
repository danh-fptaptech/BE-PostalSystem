using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Models.DTOs.res
{
    public class SDTORole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public EStatusData Status { get; set; }      
    }
}
