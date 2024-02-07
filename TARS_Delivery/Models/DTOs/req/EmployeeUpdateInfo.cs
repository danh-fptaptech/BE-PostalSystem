using System.ComponentModel.DataAnnotations;

namespace TARS_Delivery.Models.DTOs.req
{
    public class EmployeeUpdateInfo
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "It must correct email format: xxx@xxx.xxx")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Province is required.")]
        public string Province { get; set; }

        [Required(ErrorMessage = "District is required.")]
        public string District { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must have 10 digits.")]
        public string PhoneNumber { get; set; }
        public string? Avatar { get; set; }
    }
}
