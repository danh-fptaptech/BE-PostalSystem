using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.DTOs.res
{
    public class SDTOBranch
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string PostalCode { get; set; }
        public EStatusData Status { get; set; }
    }
}
