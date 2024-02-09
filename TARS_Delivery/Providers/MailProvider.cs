using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using TARS_Delivery.Options;

namespace TARS_Delivery.Providers;

internal class MailProvider(IOptions<MailOptions> options) : IMailProvider
{
    private readonly MailOptions _options = options.Value;

    public async Task Send(string receiver, string subject, string body, CancellationToken cancellationToken)
    {
        MailAddress senderAddress = new(_options.Username);

        MailAddress receiverAddress = new(receiver);

        SmtpClient smtpClient = new(_options.Host, _options.Port)
        {
            EnableSsl = _options.EnableSSL,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            Credentials = new NetworkCredential(_options.Username, _options.Password)
        };

        MailMessage message = new(senderAddress, receiverAddress)
        {
            Subject = subject,
            Body = body,
        };

        await smtpClient.SendMailAsync(message, cancellationToken);
    }
}
