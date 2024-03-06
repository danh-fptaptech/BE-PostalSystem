using System.Security.Claims;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Providers;

public interface IJwtProvider
{
    string Generate(User user);

    string Generate(Employee employee);

    ClaimsPrincipal GetClaimsPrincipalFromExpiredToken(string token);
}
