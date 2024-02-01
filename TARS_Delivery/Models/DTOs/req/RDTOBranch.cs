using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TARS_Delivery.Models.Entities
{
    public class RDTOBranch
    {
        public string BranchName { get; set; }
        
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
        
        public string Province { get; set; }
        
        public string City { get; set; }

        public string District { get; set; }

        public int PostalCode { get; set; }
        
    }
}
