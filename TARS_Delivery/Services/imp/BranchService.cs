using AutoMapper;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp;

public class BranchService : IBranchService
{
    private readonly IBranchRepository _rp;
    private readonly IMapper _mapper;

    public BranchService(IBranchRepository branchRepository, IMapper mapper)
    {
        _rp = branchRepository;
        _mapper = mapper;
    }
    
    public async Task<ICollection<Branch>> GetAllBranches()
    {
        ICollection<Branch> branches = await _rp.GetAllBranches();
        return branches;
    }

    public async Task<Branch> GetBranchById(int id)
    {
        return await _rp.GetBranchById(id);
    }

    public async Task<Branch> AddBranch(RDTOBranch branch)
    {
        if (await _rp.NameExists(branch.BranchName))
        {
            throw new Exception("Branch name already exists");
        }
        Branch newBranch = new()
        {
            BranchName = branch.BranchName,
            Address = branch.Address,
            Province = branch.Province,
            District = branch.District,
            PhoneNumber = branch.PhoneNumber,
            PostalCode = branch.PostalCode,
            Status = EStatusData.Active,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        return await _rp.AddBranch(newBranch);
    }

    public async Task<Branch> UpdateBranch(int id, RDTOBranch branch)
    {   
        if (await _rp.NameExists(branch.BranchName, id))
        {
            throw new Exception("Branch name already exists");
        }
        return await _rp.UpdateBranch(id, branch);
    }

    public async Task<bool> ToggleBranchStatus(int id)
    {
        return await _rp.ToggleBranchStatus(id);
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

    public Task<ICollection<Package>> GetAllPackagesByBranchId(int id)
    {
        return _rp.GetAllPackagesByBranchId(id);
    }

    public Task<ICollection<Item>> GetAllItemsByBranchId(int id)
    {
        return _rp.GetAllItemsByBranchId(id);
    }
}