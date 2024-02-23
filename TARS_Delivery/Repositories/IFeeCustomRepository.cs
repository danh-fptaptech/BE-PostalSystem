using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Repositories
{
    public interface IFeeCustomRepository
    {
        Task<ICollection<FeeCustom>> GetAllFees();
        Task<FeeCustom> GetFeeById(int id);
        Task<FeeCustom> CreateFee(FeeCustom fee);
        Task<FeeCustom> UpdateFee(int id, FeeCustom fee);
        Task ChangeStatus(int id);
        Task<List<FeeCustom>> GetFeeByPostalCode(string postalCodeFrom, string postalCodeTo);
/*        Task<FeeCustom> CreateUpdateFee(string postalCodeFrom, string postalCodeTo,FeeCustom fee);*/
        Task<List<FeeCustom>> GetFeeByPostalCodeWeight(string postalCodeFrom, string postalCodeTo,int weight);
    }
}
