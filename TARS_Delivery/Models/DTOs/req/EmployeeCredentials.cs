using System.ComponentModel.DataAnnotations;

namespace TARS_Delivery.Models.DTOs.req
{
    public class EmployeeCredentials
    {
        //[Required(ErrorMessage = "Email is required.")]
        //[EmailAddress(ErrorMessage = "It must correct email format: xxx@xxx.xxx")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
}