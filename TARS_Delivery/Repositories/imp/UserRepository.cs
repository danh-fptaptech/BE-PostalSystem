using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp;

internal class UserRepository(DatabaseContext dbContext) : IUserRepository
{
    private readonly DatabaseContext _dbContext = dbContext;

    public Task<User?> GetUserByIdAsync(int id, 
        CancellationToken cancellationToken)
    {
        return _dbContext
            .Users
            .FirstOrDefaultAsync(
                u => u.Id == id, 
                cancellationToken);
    }

    public Task<User?> GetUserByEmailAsync(string email, 
        CancellationToken cancellationToken)
    {
        return _dbContext
            .Users
            .FirstOrDefaultAsync(
                u => u.Email == email,
                cancellationToken);
    }

    public Task<User?> GetUserByPhoneAsync(string phone,
        CancellationToken cancellationToken)
    {
        return _dbContext
            .Users
            .FirstOrDefaultAsync(
                u => u.Phone == phone,
                cancellationToken);
    }

    public Task<User?> GetUserByIdWithAddressListAsync(
        int id, CancellationToken cancellationToken)
    {
        return _dbContext
            .Users.Include(u => u.Customers)
            .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
    }

    public Task<bool> CheckUserIsExisting(
        string email, 
        string phone, 
        CancellationToken cancellationToken)
    {
        return _dbContext
            .Users
            .AnyAsync(
                u => u.Email == email || u.Phone == phone, 
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
