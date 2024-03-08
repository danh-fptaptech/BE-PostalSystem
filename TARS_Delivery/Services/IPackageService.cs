using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services;

public interface IPackageService
{
    Task<ICollection<Package>> GetAllPackages();
    Task<Package> GetPackageById(int id);
    Task<Package> AddPackage(RDTOPackage package);
    Task<Package> EmpAddPackage(RDTOEmpPackage package);
    Task<bool> CancelPackage(int id);
    bool TogglePackageStatus(int id);
    Task<bool> AddPickup(int id, int empId);
    Task<Package> GetPackageByTrackingNumber(string trackingNumber, string phoneFrom);
}