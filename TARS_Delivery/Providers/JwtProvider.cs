using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Options;

namespace TARS_Delivery.Providers;

internal class JwtProvider(IOptions<JwtOptions> options) : IJwtProvider
{
    private readonly JwtOptions _options = options.Value;

    public string Generate(User user)
    {
        List<Claim> claims =
        [
            new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new(JwtRegisteredClaimNames.Email, user.Email),
        ];

        SigningCredentials signingCredentials = new(
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_options.SecretKey)),
            SecurityAlgorithms.HmacSha256);

        JwtSecurityToken token = new(
            _options.Issuer,
            _options.Audience,
            claims,
            null,
            DateTime.Now.AddMinutes(5),
            signingCredentials);

        string tokenValue = new JwtSecurityTokenHandler()
            .WriteToken(token);

        return tokenValue;
    }

    public string Generate(Employee employee)
    {
        List<Claim> claims =
        [
            new(JwtRegisteredClaimNames.Sub, employee.Id.ToString()),
            new(JwtRegisteredClaimNames.Email, employee.Email),
        ];

        claims.Add(new("role", employee.Role.RoleName));

        foreach (var rhp in employee.Role.RoleHasPermissions)
        {
            var permission = rhp.Permission.PermissionName;

            claims.Add(new("permission", permission));
        }

        SigningCredentials signingCredentials = new(
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_options.SecretKey)),
            SecurityAlgorithms.HmacSha256);

        JwtSecurityToken token = new(
            _options.Issuer,
            _options.Audience,
            claims,
            null,
            DateTime.Now.AddHours(1),
            signingCredentials);

        string tokenValue = new JwtSecurityTokenHandler()
            .WriteToken(token);

        return tokenValue;
    }

    public ClaimsPrincipal GetClaimsPrincipalFromExpiredToken(string token)
    {
        TokenValidationParameters validationParams = new()
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = false,
            ValidateIssuerSigningKey = true,
            ValidIssuer = _options.Issuer,
            ValidAudience = _options.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_options.SecretKey)),
            ClockSkew = new TimeSpan(0, 0, 5)
        };

        ClaimsPrincipal claimsPrincipal = new JwtSecurityTokenHandler()
        {
            MapInboundClaims = false,
        }
        .ValidateToken(token, validationParams, out _);

        return claimsPrincipal;
    }
}
