namespace TARS_Delivery.Providers;

internal interface IMailProvider
{
    public Task Send(string receiver, string subject, string body, CancellationToken cancellationToken);
}
