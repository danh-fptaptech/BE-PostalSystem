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
            if(fee != null)
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
            var feeCustoms = await _context.FeeCustoms.ToListAsync();
            return feeCustoms;
        }

        public async Task<FeeCustom> GetFeeById(int id)
        {
            var feeCustom = await _context.FeeCustoms.FirstOrDefaultAsync(fee => fee.Id == id);
            if (feeCustom != null)
            {
                return feeCustom;
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
        public async Task<FeeCustom> GetFeeByPostalCode(string postalCodeFrom, string postalCodeTo)
        {
            var postalCodeFromItem = await _context.Locations
                .FirstOrDefaultAsync(l => l.PostalCode.Equals(postalCodeFrom));
            var postalCodeToItem = await _context.Locations
                .FirstOrDefaultAsync(l => l.PostalCode.Equals(postalCodeTo));

            if (postalCodeFromItem != null && postalCodeToItem != null)
            {
                var feeCustom = await _context.FeeCustoms
                    .FirstOrDefaultAsync(fee => fee.LocationIdFrom == postalCodeFromItem.Id && fee.LocationIdTo == postalCodeToItem.Id);
                return feeCustom;
            }
            return null;
        }
    }
}
