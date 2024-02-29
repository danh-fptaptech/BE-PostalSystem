﻿using AutoMapper;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp;

public class PackageService : IPackageService
{
    private readonly IPackageRepository _rp;
    private readonly IMapper _mapper;
    
    public PackageService(IPackageRepository rp, IMapper mapper)
    {
        _rp = rp;
        _mapper = mapper;
    }

    public async Task<ICollection<SDTOPackageList>> GetAllPackages()
    {
        ICollection<Package> packages = await _rp.GetAllPackages();
        return _mapper.Map<ICollection<SDTOPackageList>>(packages);
    }

    public async Task<Package> GetPackageById(int id)
    {
        return await _rp.GetPackageById(id);
    }

    public async Task<Package> UserAddPackage(RDTOPackage package)
    {
        Package newPackage = _mapper.Map<Package>(package);
        return await _rp.AddPackage(newPackage);
    }
    
    public async Task<bool> CancelPackage(int id)
    {
        try
        {
            Package package = await _rp.FindPackageById(id);
            if(package == null) return false;
            package.Step = EPackageStatus.Cancelled;
            package.UpdatedAt = DateTime.Now;
            await _rp.UpdatePackage(id, package);
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }
    
    public async Task<Package> EmpAddPackage(RDTOEmpPackage package)
    {
        Package newPackage = _mapper.Map<Package>(package);
        return await _rp.AddPackage(newPackage);
    }

    public Task<Package> UpdatePackage(int id, Object package)
    {
        return null;
    }

    public bool TogglePackageStatus(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Package> GetPackageByTrackingNumber(string trackingNumber)
    {
        return _rp.GetPackageByTrackingNumber(trackingNumber);
    }
}