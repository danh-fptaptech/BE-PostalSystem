using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories;

public interface IPackageRepository
{
    Task<ICollection<Package>> GetAllPackages();
    Task<Package> GetPackageById(int id);
    Task<Package> AddPackage(Package package);
    Task<Package> UpdatePackage(int id, Package package);
    Task<bool> TogglePackageStatus(int id);
    Task<Package> GetPackageByTrackingNumber(string trackingNumber, string phoneFrom );
    Task<Package> FindPackageById(int id);
}