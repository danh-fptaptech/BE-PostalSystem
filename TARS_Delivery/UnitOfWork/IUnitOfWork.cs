namespace TARS_Delivery.UnitOfWork;

internal interface IUnitOfWork
{
    Task SaveChangeAsync(CancellationToken cancellationToken);
}
