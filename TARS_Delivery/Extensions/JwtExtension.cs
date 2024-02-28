using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TARS_Delivery.Options;

namespace TARS_Delivery.Extensions;

internal static class JwtExtension
{
    public static IServiceCollection ConfigureJwtSetup(
        this IServiceCollection services, IConfiguration configuration)
    {
        var jwtSection = configuration.GetSection(JwtOptions.Jwt);

        JwtOptions jwtOptions = jwtSection.Get<JwtOptions>()!;

        services.Configure<JwtOptions>(jwtSection);

        services.PostConfigureAll<JwtBearerOptions>(options =>
        {
            options.TokenValidationParameters = new()
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtOptions.Issuer,
                ValidAudience = jwtOptions.Audience,
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(jwtOptions.SecretKey)),
                ClockSkew = new TimeSpan(0, 0, 5)
            };

            options.MapInboundClaims = false;        
        });

        return services;
    }
}
