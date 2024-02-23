using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Repositories.imp
{
    public class FeeCustomRepository : IFeeCustomRepository
    {
        private readonly DatabaseContext _context;
        public FeeCustomRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<FeeCustom> CreateFee(FeeCustom fee)
        {

            if (fee != null)
            {
                _context.FeeCustoms.Add(fee);
                await _context.SaveChangesAsync();
            }
            return fee;
        }

        public async Task ChangeStatus(int id)
        {
            var feeCustom = await _context.FeeCustoms.FindAsync(id);
            if (feeCustom != null)
            {
                feeCustom.Status = feeCustom.Status == EStatusData.Active ? EStatusData.Inactive : EStatusData.Active;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<ICollection<FeeCustom>> GetAllFees()
        {
            /*var feeCustoms = await _context.FeeCustoms.ToListAsync();*/
            var feeCustoms = await _context.FeeCustoms
            .Include(fee => fee.LocationFrom)
            .Include(fee => fee.LocationTo)
            .Select(fee => new
            {
                fee.Id,
                fee.ServiceId,
                fee.LocationIdFrom,
                fee.LocationIdTo,
                fee.Distance,
                fee.FeeCharge,
                fee.TimeProcess,
                fee.CreatedAt,
                fee.UpdatedAt,
                fee.Status,
                LocationFrom = new
                {
                    fee.LocationFrom.Id,
                    fee.LocationFrom.LocationName,
                    fee.LocationFrom.PostalCode,
                    fee.LocationFrom.LocationLevel,
                    fee.LocationFrom.LocationOf,
                    fee.LocationFrom.CreatedAt,
                    fee.LocationFrom.UpdatedAt,
                    fee.LocationFrom.Status
                },
                LocationTo = new
                {
                    fee.LocationTo.Id,
                    fee.LocationTo.LocationName,
                    fee.LocationTo.PostalCode,
                    fee.LocationTo.LocationLevel,
                    fee.LocationTo.LocationOf,
                    fee.LocationTo.CreatedAt,
                    fee.LocationTo.UpdatedAt,
                    fee.LocationTo.Status
                }
            })
            .ToListAsync();

                // Mapping lại dữ liệu từ anonymous type sang FeeCustom
                var mappedFeeCustoms = feeCustoms.Select(fee => new FeeCustom
                {
                    Id = fee.Id,
                    ServiceId = fee.ServiceId,
                    LocationIdFrom = fee.LocationIdFrom,
                    LocationIdTo = fee.LocationIdTo,
                    Distance = fee.Distance,
                    FeeCharge = fee.FeeCharge,
                    TimeProcess = fee.TimeProcess,
                    CreatedAt = fee.CreatedAt,
                    UpdatedAt = fee.UpdatedAt,
                    Status = fee.Status,
                    LocationFrom = new Location
                    {
                        Id = fee.LocationFrom.Id,
                        LocationName = fee.LocationFrom.LocationName,
                        PostalCode = fee.LocationFrom.PostalCode,
                        LocationLevel = fee.LocationFrom.LocationLevel,
                        LocationOf = fee.LocationFrom.LocationOf,
                        CreatedAt = fee.LocationFrom.CreatedAt,
                        UpdatedAt = fee.LocationFrom.UpdatedAt,
                        Status = fee.LocationFrom.Status
                    },
                    LocationTo = new Location
                    {
                        Id = fee.LocationTo.Id,
                        LocationName = fee.LocationTo.LocationName,
                        PostalCode = fee.LocationTo.PostalCode,
                        LocationLevel = fee.LocationTo.LocationLevel,
                        LocationOf = fee.LocationTo.LocationOf,
                        CreatedAt = fee.LocationTo.CreatedAt,
                        UpdatedAt = fee.LocationTo.UpdatedAt,
                        Status = fee.LocationTo.Status
                    }
                }).ToList();

            return mappedFeeCustoms;
        }

        public async Task<FeeCustom> GetFeeById(int id)
        {
            var feeCustom = await _context.FeeCustoms.Include(l =>l.LocationFrom).Include(l=>l.LocationTo).FirstOrDefaultAsync(fee => fee.Id == id);
            if (feeCustom != null)
            {
                var mappedFeeCustoms = new FeeCustom
                {
                    Id = feeCustom.Id,
                    ServiceId = feeCustom.ServiceId,
                    LocationIdFrom = feeCustom.LocationIdFrom,
                    LocationIdTo = feeCustom.LocationIdTo,
                    Distance = feeCustom.Distance,
                    FeeCharge = feeCustom.FeeCharge,
                    TimeProcess = feeCustom.TimeProcess,
                    CreatedAt = feeCustom.CreatedAt,
                    UpdatedAt = feeCustom.UpdatedAt,
                    Status = feeCustom.Status,
                    LocationFrom = new Location
                    {
                        Id = feeCustom.LocationFrom.Id,
                        LocationName = feeCustom.LocationFrom.LocationName,
                        PostalCode = feeCustom.LocationFrom.PostalCode,
                        LocationLevel = feeCustom.LocationFrom.LocationLevel,
                        LocationOf = feeCustom.LocationFrom.LocationOf,
                        CreatedAt = feeCustom.LocationFrom.CreatedAt,
                        UpdatedAt = feeCustom.LocationFrom.UpdatedAt,
                        Status = feeCustom.LocationFrom.Status
                    },
                    LocationTo = new Location
                    {
                        Id = feeCustom.LocationTo.Id,
                        LocationName = feeCustom.LocationTo.LocationName,
                        PostalCode = feeCustom.LocationTo.PostalCode,
                        LocationLevel = feeCustom.LocationTo.LocationLevel,
                        LocationOf = feeCustom.LocationTo.LocationOf,
                        CreatedAt = feeCustom.LocationTo.CreatedAt,
                        UpdatedAt = feeCustom.LocationTo.UpdatedAt,
                        Status = feeCustom.LocationTo.Status
                    }
                };
                return mappedFeeCustoms;
            }
            
            return null;
        }

        public async Task<FeeCustom> UpdateFee(int id, FeeCustom fee)
        {
            var feeCustom = await _context.FeeCustoms.FirstOrDefaultAsync(fee => fee.Id == id);
            fee.CreatedAt = feeCustom.CreatedAt;
            fee.UpdatedAt = DateTime.Now;
            _context.Entry(feeCustom).CurrentValues.SetValues(fee);
            await _context.SaveChangesAsync();
            return feeCustom;
        }
        public async Task<List<FeeCustom>> GetFeeByPostalCode(string postalCodeFrom, string postalCodeTo)
        {
            var postalCodeFromItem = await _context.Locations
                .FirstOrDefaultAsync(l => l.PostalCode.Equals(postalCodeFrom));
            var postalCodeToItem = await _context.Locations
                .FirstOrDefaultAsync(l => l.PostalCode.Equals(postalCodeTo));

            if (postalCodeFromItem != null && postalCodeToItem != null)
            {
                var feeCustom = await _context.FeeCustoms
                    .Where(fee => fee.LocationIdFrom == postalCodeFromItem.Id && fee.LocationIdTo == postalCodeToItem.Id)
                    .ToListAsync();

                return feeCustom;
            }
            return null;
        }
       
        public async Task<List<FeeCustom>> GetFeeByPostalCodeWeight(string postalCodeFrom, string postalCodeTo, int weight)
        {
            var postalCodeFromItem = await _context.Locations
                .FirstOrDefaultAsync(l => l.PostalCode.Equals(postalCodeFrom));
            var postalCodeToItem = await _context.Locations
                .FirstOrDefaultAsync(l => l.PostalCode.Equals(postalCodeTo));

            if (postalCodeFromItem != null && postalCodeToItem != null)
            {
                var feeCustom = await _context.FeeCustoms
                    .Where(fee => fee.LocationIdFrom == postalCodeFromItem.Id && fee.LocationIdTo == postalCodeToItem.Id)
                    .Include(s => s.Service)
                    .Where(s=> s.Service.WeighFrom <= weight && s.Service.WeighTo >= weight)
                    .ToListAsync();
                if (feeCustom != null)
                {
                   return feeCustom;
                }
            }
            return null;
        }
    }
}
