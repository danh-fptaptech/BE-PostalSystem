using AutoMapper;
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
            List<Location> locations = _context.Locations.ToList();
            List<RDTOLocation> rdtolocations = _mapper.Map<List<RDTOLocation>>(locations);
            return rdtolocations;
        }

        public Task<Location> GetLocationById(int id)
        {
            var location = _context.Locations.Find(id);
            if (location == null)
            {
                return null;
            }
            return Task.FromResult(location);
        }

        public async Task UpdateLocation(int id, Location location)
        {
            var locationUpdate = _context.Locations.Find(id);
            _context.Entry(locationUpdate).CurrentValues.SetValues(location);
            await _context.SaveChangesAsync();
            return;
        }
        public async Task UpdateStatus(int id)
        {
            var location = _context.Locations.Find(id);
            location.Status = location.Status == EStatusData.Active ? EStatusData.Deactive : EStatusData.Active;
            await _context.SaveChangesAsync();
            return;
        }
        public Task<object> GetChildLocation(int id)
        {
            var location = _context.Locations.FirstOrDefault(x => x.Id == id);

            if (location == null)
            {
                return Task.FromResult<object>(null);
            }

            if (location.LocationLevel == ELocationLevel.Country)
            {
                var locationChild = _context.Locations.Where(x => x.LocationOf == id).ToList();
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
                                .Where(y => y.LocationOf == x.Id)
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
                var locationChild = _context.Locations.Where(x => x.LocationOf == id).ToList();
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
                                .Where(y => y.LocationOf == x.Id)
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
                var locationChild = _context.Locations.Where(x => x.LocationOf == id).ToList();
                if (locationChild.Any())
                {
                    var cityChild = new RDTOLocationCity
                    {
                        Id = location.Id,
                        LocationName = location.LocationName,
                        PostalCode = location.PostalCode,
                        LocationLevel = location.LocationLevel,
                        LocationOf = location.LocationOf,
                        Status = location.Status,
                        districs = locationChild.Select(x => new RDTOLocationDistric
                        {
                            Id = x.Id,
                            LocationName = x.LocationName,
                            PostalCode = x.PostalCode,
                            LocationLevel = x.LocationLevel,
                            LocationOf = x.LocationOf,
                            Status = x.Status
                        }).ToList()
                    };
                    return Task.FromResult<object>(cityChild);
                }
            }

            return Task.FromResult<object>(location);
        }


        public Task GetListLocationByLevel(ELocationLevel eLocationLevel)
        {
            var location = _context.Locations.Where(x => x.LocationLevel == eLocationLevel).ToList();
            return Task.FromResult(location);
        }
    }
}
