using MediatR;
using Microsoft.AspNetCore.Authentication;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.Users.RefreshTokenAsync;

internal sealed class RefreshTokenAsyncHandler(
    IHttpContextAccessor httpContextAccessor,
    IUserRepository userRepository,
    IJwtProvider jwtProvider) 
    : IRequestHandler<RefreshTokenAsyncCommand, string>
{
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IJwtProvider _jwtProvider = jwtProvider;

    public async Task<string> Handle(
        RefreshTokenAsyncCommand command, 
        CancellationToken cancellationToken)
    {
        var httpContext = _httpContextAccessor.HttpContext;

        if (httpContext is null)
        {
            return null;
        }

        //httpContext.Request.Headers.TryGetValue("Authorization", out var token);

        var oldToken = await httpContext.GetTokenAsync("access_token");

        if (oldToken is null)
        {
            // unauthorized
            return null;
        }

        ClaimsPrincipal claimPrincipal = _jwtProvider.GetClaimsPrincipalFromExpiredToken(oldToken);

        var userId = claimPrincipal.FindFirstValue(JwtRegisteredClaimNames.Sub);

        if (userId is null)
        {
            // unauthorized
            return null;
        }

        User? user = await _userRepository
            .GetUserByIdAsync(
                int.Parse(userId), 
                cancellationToken);

        if (user is null || 
            user.RefreshToken != httpContext.Request.Cookies["refresh-token"] ||
            user.RefreshTokenExpires < DateTime.Now)
        {
            // unauthorized
            return null;
        }

        string newToken = _jwtProvider.Generate(user);

        user.GenerateRefreshToken(httpContext);

        return newToken;
    }
}
