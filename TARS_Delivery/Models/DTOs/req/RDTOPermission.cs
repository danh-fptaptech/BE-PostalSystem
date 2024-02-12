using System.ComponentModel.DataAnnotations;

namespace TARS_Delivery.Models.DTOs.req
{
    public class RDTOPermission
    {
        [Required(ErrorMessage = "The permission name is required.")]
        public required string PermissionName { get; set; }
    }
}
