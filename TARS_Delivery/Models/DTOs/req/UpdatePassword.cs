using System.ComponentModel.DataAnnotations;

namespace TARS_Delivery.Models.DTOs.req
{
    public class UpdatePassword
    {
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
}
