using System.ComponentModel.DataAnnotations;

namespace TARS_Delivery.Models.DTOs.req
{
    public class RDTOPermisson
    {
        [Required (ErrorMessage = "The Permission name is required.")]
        public string PermissionName { get; set; }
    }
}
