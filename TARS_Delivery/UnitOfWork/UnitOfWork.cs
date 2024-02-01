using TARS_Delivery.Models;

namespace TARS_Delivery.UnitOfWork;

public class UnitOfWork(DatabaseContext dbContext) : IUnitOfWork
{
    private readonly DatabaseContext _dbContext = dbContext;

    public Task SaveChangeAsync(CancellationToken cancellationToken)
    {
        return _dbContext.SaveChangesAsync(cancellationToken);
    }
}
