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
    
    public BranchRepository(DatabaseContext db, IMapper mapper)
    {
        _db = db;
    }
    
    public async Task<ICollection<Branch>> GetAllBranches()
    {
        ICollection<Branch> branches = await _db.Branches.ToListAsync();
        return branches;
    }
     

    public async Task<Branch> GetBranchById(int id)
    {
        return await _db.Branches.Include(b => b.Employees).ThenInclude(e=>e.Role).FirstOrDefaultAsync(b=>b.Id == id);
    }


    public async Task<Branch> AddBranch(Branch branch)
    {
        try
        {
            await _db.Branches.AddAsync(branch);
            await _db.SaveChangesAsync();
            return branch;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Error while adding branch");
        }
    }

    public async Task<Branch> UpdateBranch(int id, RDTOBranch branch)
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
            await _db.SaveChangesAsync();
            return branchToUpdate;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Error while updating branch");
        }
    }

    public async Task<ICollection<Package>> GetAllPackagesByBranchId(int id)
    {
        try
        {
            ICollection<Package> packages = await _db.Branches
                .Where(b=>b.Id == id)
                .Include(b => b.Employees)
                .ThenInclude(e => e.HistoryLogs)
                .ThenInclude(h => h.Package)
                .SelectMany(b=>b.Employees)
                .SelectMany(e=>e.HistoryLogs)
                .Where(h=>h.Step == h.Package.Step)
                .Select(h=>h.Package)
                .ToListAsync();
            return packages;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Error while getting packages");
        }
    }

    public async Task<ICollection<Item>> GetAllItemsByBranchId(int id)
    {
        try
        {   
            ICollection<Item> items = await _db.Branches
                .Where(b => b.Id == id)
                .SelectMany(b => b.Employees)
                .SelectMany(e => e.HistoryLogs)
                .Where(h => h.Step == h.Package.Step)
                .SelectMany(h => h.Package.Items)
                .ToListAsync();
            return items;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Error while getting items");
        }
    }

    public async Task<bool> ToggleBranchStatus(int id)
    {
        try
        {
            Branch branchToUpdate = await _db.Branches.FindAsync(id);
            if (branchToUpdate == null)
            {
                throw new Exception("Branch not found");
            }
            branchToUpdate.Status = branchToUpdate.Status == EStatusData.Active ? EStatusData.Inactive : EStatusData.Active;
            await _db.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw e;
        }
    }

    public async Task<bool> NameExists(string name , int? id = null)
    {   
        if (id != null)
        {
            return await _db.Branches.AnyAsync(b => b.BranchName == name && b.Id != id);
        }
        return await _db.Branches.AnyAsync(b => b.BranchName == name);
    }

}