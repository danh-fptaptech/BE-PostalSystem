﻿using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Repositories.imp;

public class PackageRepository : IPackageRepository
{   
    private readonly DatabaseContext _db;
    private readonly IMapper _mapper;

    public PackageRepository(DatabaseContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<ICollection<Package>> GetAllPackages()
    {
        ICollection<Package> packages =  await _db.Packages.Include(p=>p.Service).ToListAsync();
        return packages;
    }

    public async Task<Package> GetPackageById(int id)
    {
        return await _db.Packages
            .Include(p=>p.Items)
            .Include(p=> p.Service)
            .Include(p=>p.HistoryLogs)
            .ThenInclude(h=>h.Employee)
            .ThenInclude(e=>e.Branch)
            .FirstAsync(p => p.Id == id);
    }

    public async Task<Package> AddPackage(Package package)
    {
        try
        { 
            package.TrackingCode = GenerateTrackingNumber(package.UserId);
            await _db.Packages.AddAsync(package);
            await _db.SaveChangesAsync();
            return package;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Error while adding package");
        }
    }
    
    private bool IsTrackingNumberUnique(string trackingNumber)
    {
        return _db.Packages.Any(p => p.TrackingCode == trackingNumber);
    }
    
    private string GenerateTrackingNumber(int id)
    {
        string code;
        do
        {
            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var random = new Random().Next(1000, 9999);
            code =  $"CT{id}-{timestamp}{random}";
        } while (!IsTrackingNumberUnique(code));
        return code;
    }

    public Task<Package> UpdatePackage(int id, Package package)
    {
        throw new NotImplementedException();
    }
    
    // Tạo phương thức update một số trường được chỉ định trong tham số package.
    public async Task<Package> UpdatePackage(int id, RDTOPackage package)
    {
        try
        {
            Package packageToUpdate = await _db.Packages.FindAsync(id);
            if (packageToUpdate == null)
            {
                throw new Exception("Package not found");
            }
            // Tạo config mapper để chỉ map những trường nào null hoặc empty giữ nguyên giá trị cũ
            
            
            
            packageToUpdate.UpdatedAt = DateTime.Now;
            await _db.SaveChangesAsync();
            return packageToUpdate;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("Error while updating package");
        }
    }
    
    
    

    public async Task<bool>  TogglePackageStatus(int id)
    {
        try
        {
            Package packageToUpdate = await _db.Packages.FindAsync(id);
            if (packageToUpdate == null)
            {
                return false;
            }
            packageToUpdate.Status = packageToUpdate.Status == EStatusData.Active ? EStatusData.Inactive : EStatusData.Active;
            await _db.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public async Task<Package> GetPackageByTrackingNumber(string trackingNumber)
    {
        Package package = await _db.Packages
            .Include(p=>p.Items)
            .Include(p=> p.Service)
            .Include(p=>p.HistoryLogs)
            .ThenInclude(h=>h.Employee)
            .ThenInclude(e=>e.Branch)
            .FirstOrDefaultAsync(p => p.TrackingCode == trackingNumber);
        return package;
    }

    public async Task<Package> FindPackageById(int id)
    {
        return await _db.Packages.FindAsync(id);
    }
}