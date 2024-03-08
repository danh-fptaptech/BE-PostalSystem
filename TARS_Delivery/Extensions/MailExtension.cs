using TARS_Delivery.Options;

namespace TARS_Delivery.Extensions;

internal static class MailExtension
{
    public static IServiceCollection ConfigureMailSetup(
       this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MailOptions>(configuration.GetSection(MailOptions.Mail));

        return services;
    }
}
