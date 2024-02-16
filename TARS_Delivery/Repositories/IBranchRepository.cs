using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories;

public interface IBranchRepository
{
    public Task<ICollection<SDTOBranch>> GetAllBranches();
    public Task<Branch> GetBranchById(int id);
    public Task<Branch> AddBranch(Branch branch);
    public Task<Branch> UpdateBranch(int id, RDTOBranch branch);
    public bool ToggleBranchStatus(int id);
}