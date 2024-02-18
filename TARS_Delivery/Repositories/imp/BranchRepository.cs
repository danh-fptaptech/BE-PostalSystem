using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Repositories.imp;

public class BranchRepository : IBranchRepository
{
    private readonly DatabaseContext _db;
    private readonly IMapper _mapper;
    
    public BranchRepository(DatabaseContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }
    
    public async Task<ICollection<SDTOBranch>> GetAllBranches()
    {
        ICollection<Branch> branches = await _db.Branches.ToListAsync();
        return _mapper.Map<ICollection<SDTOBranch>>(branches);
    }

    public async Task<Branch> GetBranchById(int id)
    {
        return await _db.Branches.FindAsync(id);
    }


    public Task<Branch> AddBranch(Branch branch)
    {
        try
        {
            _db.Branches.Add(branch);
            _db.SaveChanges();
            return Task.FromResult(branch);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Error while adding branch");
        }
    }

    public Task<Branch> UpdateBranch(int id, RDTOBranch branch)
    {
        try
        {
            Branch branchToUpdate = _db.Branches.Find(id);
            if (branchToUpdate == null)
            {
                throw new Exception("Branch not found");
            }
            _db.Entry(branchToUpdate).CurrentValues.SetValues(branch);
            branchToUpdate.UpdatedAt = DateTime.Now;
            _db.SaveChanges();
            return Task.FromResult(branchToUpdate);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Error while updating branch");
        }
    }

    public bool ToggleBranchStatus(int id)
    {
        try
        {
            Branch branchToUpdate = _db.Branches.Find(id);
            if (branchToUpdate == null)
            {
                throw new Exception("Branch not found");
            }
            branchToUpdate.Status = branchToUpdate.Status == EStatusData.Active ? EStatusData.Inactive : EStatusData.Active;
            _db.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Error while updating branch");
        }
    }
}