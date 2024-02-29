using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories;

internal interface IUserRepository
{
    Task<User?> GetUserByIdAsync(int id, CancellationToken cancellationToken);

    Task<User?> GetUserByEmailAsync(string email, CancellationToken cancellationToken);

    Task<User?> GetUserByPhoneAsync(string phone, CancellationToken cancellationToken);

    Task<User?> GetUserByIdWithAddressListAsync(int id, CancellationToken cancellationToken);

    Task<bool> CheckUserIsExisting(string email, string phone, CancellationToken cancellationToken);

    Task AddUser(User user, CancellationToken cancellationToken);
}
