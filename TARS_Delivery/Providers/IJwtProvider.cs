using System.Security.Claims;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Providers;

internal interface IJwtProvider
{
    string Generate(User user);

    ///string Generate(Employee employee);

    ClaimsPrincipal GetClaimsPrincipalFromExpiredToken(string token);
}
