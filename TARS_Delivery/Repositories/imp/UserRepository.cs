using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp;

internal class UserRepository(DatabaseContext dbContext) : IUserRepository
{
    private readonly DatabaseContext _dbContext = dbContext;

    public async Task<User?> GetUserByIdAsync(int id, 
        CancellationToken cancellationToken)
    {
        return await _dbContext
            .Users
            .FirstOrDefaultAsync(
                u => u.Id == id, 
                cancellationToken);
    }

    public async Task<User?> GetUserByEmailAsync(string email, 
        CancellationToken cancellationToken)
    {
        return await _dbContext
            .Users
            .FirstOrDefaultAsync(
                u => u.Email == email,
                cancellationToken);
    }

    public Task AddUser(User user, 
        CancellationToken cancellationToken)
    {
        return _dbContext
            .Users
            .AddAsync(user, cancellationToken)
            .AsTask();
    }
}
