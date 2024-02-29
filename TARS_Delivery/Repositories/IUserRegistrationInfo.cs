using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories;

internal interface IUserRegistrationInfoRepository
{
    Task AddUserRegistrationInfo(UserRegistrationInfo userInfo, CancellationToken cancellationToken);

    Task<UserRegistrationInfo?> GetUserRegistrationInfoByOtpAsync(string otp, CancellationToken cancellationToken);

    void DeleteUserRegistrationInfo(UserRegistrationInfo userInfo);
}
