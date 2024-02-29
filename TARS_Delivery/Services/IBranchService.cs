using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services;

public interface IBranchService
{
    Task<ICollection<Branch>> GetAllBranches();
    Task<Branch> GetBranchById(int id);
    Task<Branch> AddBranch(RDTOBranch branch);
    Task<Branch> UpdateBranch(int id, RDTOBranch branch);
    Task<bool> ToggleBranchStatus(int id);
    Task<ICollection<Employee>> GetAllEmployeesByBranchId(int id);
    Task<ICollection<Package>> GetAllPackagesByBranchId(int id);
    Task<ICollection<Item>> GetAllItemsByBranchId(int id);
    
}