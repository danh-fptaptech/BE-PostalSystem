using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Models.DTOs.res
{
    public class SDTOBranch
    {
        public int Id { get; set; }

        public string? BranchName { get; set; }
        
        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }
        
        public string? Province { get; set; }
        
        public string? City { get; set; }

        public string? District { get; set; }

        public int PostalCode { get; set; }
        
        public EStatusData Status { get; set; }
    }
}
