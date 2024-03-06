using System.ComponentModel.DataAnnotations;

namespace TARS_Delivery.Models.DTOs.req
{
    public class RDTORoleHasPermission
    {
        [Required]
        public int RoleId { get; set; }
        [Required]
        public int PermissionId { get; set; }
    }
}
