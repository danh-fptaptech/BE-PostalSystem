using System.ComponentModel.DataAnnotations;

namespace TARS_Delivery.Models.DTOs.req
{
    public class UpdateInfoAsync
    {
        [EmailAddress(ErrorMessage = "It must correct email format: xxx@xxx.xxx")]
        public string? Email { get; set; }

        public string? PostalCode { get; set; }

        public string? Address { get; set; }
    
        public string? Province { get; set; }
        
        public string? District { get; set; }
      
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must have 10 digits.")]
        public string? PhoneNumber { get; set; }
        public string? Avatar { get; set; }
    }
}
