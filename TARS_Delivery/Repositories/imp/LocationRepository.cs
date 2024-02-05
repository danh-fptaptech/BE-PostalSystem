using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req.Location;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enum;

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
            var location = await _context.Locations.FindAsync(id);
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

            if (location.LocationLevel == ELocationLevel.Country)
            {
                var locationChild = await _context.Locations.Where(x => x.LocationOf == id && x.Status == EStatusData.Active).ToListAsync();
                if (locationChild.Any())
                {
                    var countryChild = new RDTOLocationCountry
                    {
                        Id = location.Id,
                        LocationName = location.LocationName,
                        PostalCode = location.PostalCode,
                        LocationLevel = location.LocationLevel,
                        LocationOf = location.LocationOf,
                        Status = location.Status,
                        provinces = locationChild.Select(x => new RDTOLocationProvince
                        {
                            Id = x.Id,
                            LocationName = x.LocationName,
                            PostalCode = x.PostalCode,
                            LocationLevel = x.LocationLevel,
                            LocationOf = x.LocationOf,
                            Status = x.Status,
                            cities = _context.Locations
                                .Where(y => y.LocationOf == x.Id && x.Status == EStatusData.Active)
                                .Select(y => new RDTOLocationCity
                                {
                                    Id = y.Id,
                                    LocationName = y.LocationName,
                                    PostalCode = y.PostalCode,
                                    LocationLevel = y.LocationLevel,
                                    LocationOf = y.LocationOf,
                                    Status = y.Status,
                                    districs = _context.Locations
                                        .Where(z => z.LocationOf == y.Id)
                                        .Select(z => new RDTOLocationDistric
                                        {
                                            Id = z.Id,
                                            LocationName = z.LocationName,
                                            PostalCode = z.PostalCode,
                                            LocationLevel = z.LocationLevel,
                                            LocationOf = z.LocationOf,
                                            Status = z.Status
                                        }).ToList()
                                }).ToList()
                        }).ToList()
                    };
                    return Task.FromResult<object>(countryChild);
                }
            }
            else if (location.LocationLevel == ELocationLevel.Province)
            {
                var locationChild = await _context.Locations.Where(x => x.LocationOf == id && x.Status == EStatusData.Active).ToListAsync();
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
                        cities = locationChild.Select(x => new RDTOLocationCity
                        {
                            Id = x.Id,
                            LocationName = x.LocationName,
                            PostalCode = x.PostalCode,
                            LocationLevel = x.LocationLevel,
                            LocationOf = x.LocationOf,
                            Status = x.Status,
                            districs = _context.Locations
                                .Where(y => y.LocationOf == x.Id && x.Status == EStatusData.Active)
                                .Select(y => new RDTOLocationDistric
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
                    return Task.FromResult<object>(provinceChild);
                }
            }
            else if (location.LocationLevel == ELocationLevel.City)
            {
                var locationChild = await _context.Locations.Where(x => x.LocationOf == id && x.Status == EStatusData.Active).ToListAsync();
                if (locationChild.Any())
                {
                    var districs =  locationChild.Select(x => new RDTOLocationDistric
                    {
                        Id = x.Id,
                        LocationName = x.LocationName,
                        PostalCode = x.PostalCode,
                        LocationLevel = x.LocationLevel,
                        LocationOf = x.LocationOf,
                        Status = x.Status
                    }).ToList();

                    var cityChild = new RDTOLocationCity
                    {
                        Id = location.Id,
                        LocationName = location.LocationName,
                        PostalCode = location.PostalCode,
                        LocationLevel = location.LocationLevel,
                        LocationOf = location.LocationOf,
                        Status = location.Status,
                        districs = districs.Count > 0 ? districs : null
                    };
                    return Task.FromResult<object>(cityChild);
                }
            }
            else if (location.LocationLevel == ELocationLevel.District)
            {
                return Task.FromResult<object>(null);
            }
            return Task.FromResult<object>(location);
        }


        public async Task<List<RDTOLocation>> GetListLocationByLevel(ELocationLevel eLocationLevel)
        {
            var locations = await _context.Locations.Where(x => x.LocationLevel == eLocationLevel && x.Status == EStatusData.Active).ToListAsync();
            if (locations.Count > 0)
            {
                List<RDTOLocation> rdtolocations = _mapper.Map<List<RDTOLocation>>(locations);
                return rdtolocations;
            }
            return null;
        }
        public async Task<RDTOLocationByZipcode> GetLocationByCode(int zipcode)
        {
            var location = await _context.Locations.FirstOrDefaultAsync(x => x.PostalCode == zipcode && x.LocationLevel == ELocationLevel.District && x.Status == EStatusData.Active);
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
