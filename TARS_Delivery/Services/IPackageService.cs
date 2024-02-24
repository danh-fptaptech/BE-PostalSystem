using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services;

public interface IPackageService
{
    Task<ICollection<SDTOPackageList>> GetAllPackages();
    Task<Package> GetPackageById(int id);
    Task<Package> UserAddPackage(RDTOPackage package);
    Task<Package> EmpAddPackage(RDTOEmpPackage package);
    Task<bool> CancelPackage(int id);
    Task<Package> UpdatePackage(int id, Object package);
    bool TogglePackageStatus(int id);
    Task<Package> GetPackageByTrackingNumber(string trackingNumber);
}