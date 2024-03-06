namespace TARS_Delivery.Providers;

public interface IMailProvider
{
    public Task Send(string receiver, string subject, string body, CancellationToken cancellationToken);
}
