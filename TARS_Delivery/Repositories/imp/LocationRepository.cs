using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req.Location;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Repositories.imp
{
    public class LocationRepository : ILocationRepository
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        public LocationRepository(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddLocation(Location location)
        {
            _context.Locations.AddAsync(location);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLocation(int id)
        {
            var location = await _context.Locations.FindAsync(id);
            if (location != null)
            {
                _context.Locations.Remove(location);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<ICollection<RDTOLocation>> GetAllLocations()
        {
            List<Location> locations = await _context.Locations.ToListAsync();
            List<RDTOLocation> rdtolocations = _mapper.Map<List<RDTOLocation>>(locations);
            return rdtolocations;
        }

        public async Task<Location> GetLocationById(int id)
        {
            var location = await _context.Locations.Include(l=>l.ChildLocations).Include(l=>l.ParentLocation).FirstAsync(l=>l.Id == id);
            
            if (location == null)
            {
                return null;
            }
            return location;
        }

        public async Task UpdateLocation(int id, Location location)
        {
            var locationUpdate = await _context.Locations.FindAsync(id);
            location.CreatedAt = locationUpdate.CreatedAt;
            location.UpdatedAt = DateTime.Now;
            _context.Entry(locationUpdate).CurrentValues.SetValues(location);
            await _context.SaveChangesAsync();
            return;
        }
        public async Task UpdateStatus(int id)
        {
            var location = await _context.Locations.FindAsync(id);
            location.Status = location.Status == EStatusData.Active ? EStatusData.Inactive : EStatusData.Active;
            await _context.SaveChangesAsync();
            return;
        }
        public async Task<object> GetChildLocation(int id)
        {
            var location = await _context.Locations.FirstOrDefaultAsync(x => x.Id == id);

            if (location == null)
            {
                return Task.FromResult<object>(null);
            }
            if (location.Status == EStatusData.Inactive)
            {
                return Task.FromResult<object>(null);
            }
            else if (location.LocationLevel == ELocationLevel.Province)
            {
                var locationChild = await _context.Locations.Where(x => x.LocationOf == id).ToListAsync();
                if (locationChild.Any())
                {
                    var provinceChild = new RDTOLocationProvince
                    {
                        Id = location.Id,
                        LocationName = location.LocationName,
                        PostalCode = location.PostalCode,
                        LocationLevel = location.LocationLevel,
                        LocationOf = location.LocationOf,
                        Status = location.Status,
                        Districs = locationChild.Select(x => new RDTOLocationDistric
                        {
                            Id = x.Id,
                            LocationName = x.LocationName,
                            PostalCode = x.PostalCode,
                            LocationLevel = x.LocationLevel,
                            LocationOf = x.LocationOf,
                            Status = x.Status,
                            Wards = _context.Locations
                                .Where(y => y.LocationOf == x.Id)
                                .Select(y => new RDTOLocationWard
                                {
                                    Id = y.Id,
                                    LocationName = y.LocationName,
                                    PostalCode = y.PostalCode,
                                    LocationLevel = y.LocationLevel,
                                    LocationOf = y.LocationOf,
                                    Status = y.Status
                                }).ToList()
                        }).ToList()
                    };
                    return Task.FromResult<object>(provinceChild).Result;
                }
            }
            else if (location.LocationLevel == ELocationLevel.District)
            {
                var locationChild = await _context.Locations.Where(x => x.LocationOf == id).ToListAsync();
                if (locationChild.Any())
                {
                    var wards =  locationChild.Select(x => new RDTOLocationWard
                    {
                        Id = x.Id,
                        LocationName = x.LocationName,
                        PostalCode = x.PostalCode,
                        LocationLevel = x.LocationLevel,
                        LocationOf = x.LocationOf,
                        Status = x.Status
                    }).ToList();

                    var districtChild = new RDTOLocationDistric
                    {
                        Id = location.Id,
                        LocationName = location.LocationName,
                        PostalCode = location.PostalCode,
                        LocationLevel = location.LocationLevel,
                        LocationOf = location.LocationOf,
                        Status = location.Status,
                        Wards = wards.Count > 0 ? wards : null
                    };
                    return Task.FromResult<object>(districtChild).Result;
                }
            }
            else if (location.LocationLevel == ELocationLevel.Ward)
            {
                return Task.FromResult<object>(null);
            }
            return Task.FromResult<object>(location).Result;
        }


        public async Task<List<RDTOLocation>> GetListLocationByLevel(ELocationLevel eLocationLevel)
        {
            var locations = await _context.Locations.Where(x => x.LocationLevel == eLocationLevel).ToListAsync();
            if (locations.Count > 0)
            {
                List<RDTOLocation> rdtolocations = _mapper.Map<List<RDTOLocation>>(locations);
                return rdtolocations;
            }
            return null;
        }
        public async Task<RDTOLocationByZipcode> GetLocationByCode(string zipcode)
        {
            var location = await _context.Locations.FirstOrDefaultAsync(x => x.PostalCode == zipcode && x.LocationLevel == ELocationLevel.District);
            if (location != null)
            {
                var rdtolocation = _mapper.Map<RDTOLocationByZipcode>(location);
                if (location.LocationOf.HasValue)
                {
                    var LocationOfString = await GetLocationById(location.LocationOf.Value);
                    rdtolocation.LocationOfString = LocationOfString.LocationName;
                }
                rdtolocation.LocationLevelString = Enum.GetName(typeof(ELocationLevel), location.LocationLevel);
                return rdtolocation;
            }
            return null;
        }
    }
}
