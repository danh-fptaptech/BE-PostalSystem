using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TARS_Delivery.Models.DTOs.req
{
    public class RDTOBranch
    {   
        [Required(ErrorMessage = "Branch name is required")]
        public string BranchName { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Province is required")]
        public string Province { get; set; }
        [Required(ErrorMessage = "District is required")]
        public string District { get; set; }
        [Required(ErrorMessage = "Postal code is required")]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "Invalid postal code")]
        public string PostalCode { get; set; }
        
    }
}
