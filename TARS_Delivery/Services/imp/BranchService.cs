using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enum;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp;

public class BranchService : IBranchService
{
    private readonly IBranchRepository _rp;

    public BranchService(IBranchRepository branchRepository)
    {
        _rp = branchRepository;
    }
    
    public async Task<ICollection<SDTOBranch>> GetAllBranches()
    {
        return await _rp.GetAllBranches();
    }

    public async Task<Branch> GetBranchById(int id)
    {
        return await _rp.GetBranchById(id);
    }

    public Branch AddBranch(RDTOBranch branch)
    {
        Branch newBranch = new()
        {
            BranchName = branch.BranchName,
            Address = branch.Address,
            Province = branch.Province,
            City = branch.City,
            District = branch.District,
            PhoneNumber = branch.PhoneNumber,
            PostalCode = branch.PostalCode,
            Status = EStatusData.Active,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        return _rp.AddBranch(newBranch).Result;
    }

    public Branch UpdateBranch(int id, RDTOBranch branch)
    {
        return _rp.UpdateBranch(id, branch).Result;
    }

    public bool ToggleBranchStatus(int id)
    {
        return _rp.ToggleBranchStatus(id);
    }
    
    public async Task<ICollection<Employee>> GetAllEmployeesByBranchId(int id)
    {
        Branch branch = await _rp.GetBranchById(id);
        if (branch == null)
        {
            throw new Exception("Branch not found");
        }
        return branch.Employees;
    }
}