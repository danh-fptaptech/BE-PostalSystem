using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services;

internal interface IBranchService
{
    Task<ICollection<SDTOBranch>> GetAllBranches();
    Task<Branch> GetBranchById(int id);
    Branch AddBranch(RDTOBranch branch);
    
    Branch UpdateBranch(int id, RDTOBranch branch);
    
    bool ToggleBranchStatus(int id);
    
    Task<ICollection<Employee>> GetAllEmployeesByBranchId(int id);
    
    
}