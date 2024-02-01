using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories;

internal interface IUserRepository
{
    Task<User?> GetUserByIdAsync(int id, CancellationToken cancellationToken);

    Task<User?> GetUserByEmailAsync(string email, CancellationToken cancellationToken);

    Task AddUser(User user, CancellationToken cancellationToken);
}
