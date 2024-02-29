using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp;

internal class UserRegistrationInfoRepository(DatabaseContext dbContext) 
    : IUserRegistrationInfoRepository
{
    private readonly DatabaseContext _dbContext = dbContext;

    public Task AddUserRegistrationInfo(
        UserRegistrationInfo userInfo, CancellationToken cancellationToken)
    {
        return _dbContext
            .UserRegistrations
            .AddAsync(userInfo, cancellationToken)
            .AsTask();
    }

    public void DeleteUserRegistrationInfo(UserRegistrationInfo userInfo)
    {
        _dbContext.UserRegistrations.Remove(userInfo);
    }

    public Task<UserRegistrationInfo?> GetUserRegistrationInfoByOtpAsync(
        string otp, CancellationToken cancellationToken)
    {
        return _dbContext
            .UserRegistrations
            .FirstOrDefaultAsync(u => u.Otp == otp 
                && u.CreatedAt > DateTime.Now.AddMinutes(-3), 
            cancellationToken);
    }
}
