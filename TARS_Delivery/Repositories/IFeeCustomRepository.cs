using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Repositories
{
    public interface IFeeCustomRepository
    {
        Task<ICollection<FeeCustom>> GetAllFees();
        Task<FeeCustom> GetFeeById(int id);
        Task<FeeCustom> CreateFee(FeeCustom fee);
        Task<FeeCustom> UpdateFee(int id, FeeCustom fee);
        Task ChangeStatus(int id);
        Task<FeeCustom> GetFeeByPostalCode(string postalCodeFrom, string postalCodeTo);
    }
}
