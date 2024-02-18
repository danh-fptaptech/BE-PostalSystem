using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req.Location;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Repositories
{
    public interface ILocationRepository
    {
        Task<ICollection<RDTOLocation>> GetAllLocations();
        Task<Location> GetLocationById(int id);
        Task AddLocation(Location location);
        Task UpdateLocation(int id, Location location);
        Task DeleteLocation(int id);
        Task<object> GetChildLocation(int id);
        Task<List<RDTOLocation>> GetListLocationByLevel(ELocationLevel eLocationLevel);
        Task<RDTOLocationByZipcode> GetLocationByCode(string zipcode);
        Task UpdateStatus(int id);
    }
}
