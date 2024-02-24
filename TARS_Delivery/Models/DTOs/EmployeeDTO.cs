using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.DTOs
{
    public class EmployeeDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "EmployeeCode is required.")]
        public required string EmployeeCode { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Email must correct email format. ")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Fullname is required.")]
        public required string Fullname { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public required string Address { get; set; }

        [Required(ErrorMessage = "Province is required.")]
        public required string Province { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public required string City { get; set; }

        [Required(ErrorMessage = "District is required.")]
        public required string District { get; set; }

        [Required(ErrorMessage = "PostalCode is required.")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required.")]
        public required string PhoneNumber { get; set; }
        public string? Avatar { get; set; }

        public required ICollection<string> Roles { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public EStatusData Status { get; set; }
    }
}
