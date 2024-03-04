using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.DTOs.req
{
    public class RDTOEmployee
    {
        [Required(ErrorMessage = "The employee code is required.")]
        [RegularExpression(@"^EMP-\d{6}$", ErrorMessage = "The employee code must have format EMP-xxxxxx, x is a digit.")]
        public string EmployeeCode { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "It must correct email format: xxx@xxx.xxx")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = ("Password must be at least 8 characters."))]
        //[RegularExpression(@"^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[^\da-zA-Z])$", ErrorMessage = "Password must include at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Fullname is required.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = ("Fullname must be at least 8 characters."))]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Postal Code is required.")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Province is required.")]
        public string Province { get; set; }

        [Required(ErrorMessage = "District is required.")]
        public string District { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must have 10 digits.")]
        public string PhoneNumber { get; set; }
        public string? Avatar { get; set; }
        public string? SubmitedInfo { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public EStatusData Status { get; set; }
        public int BranchId { get; set; }
        public int RoleId { get; set; }
    }
}
