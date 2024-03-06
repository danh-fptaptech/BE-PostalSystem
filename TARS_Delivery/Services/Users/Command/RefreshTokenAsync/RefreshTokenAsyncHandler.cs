using MediatR;
using Microsoft.AspNetCore.Authentication;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Command.RefreshTokenAsync;

internal sealed class RefreshTokenAsyncHandler(
    IHttpContextAccessor httpContextAccessor,
    IUserRepository userRepository,
    IJwtProvider jwtProvider)
    : IRequestHandler<RefreshTokenAsyncCommand, Result<RefreshTokenAsyncResponse>>
{
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IJwtProvider _jwtProvider = jwtProvider;

    public async Task<Result<RefreshTokenAsyncResponse>> Handle(
        RefreshTokenAsyncCommand command,
        CancellationToken cancellationToken)
    {
        var httpContext = _httpContextAccessor.HttpContext!;

        var oldToken = await httpContext.GetTokenAsync("access_token");

        if (oldToken is null)
        {
            return Result.Failure<RefreshTokenAsyncResponse>(RefreshTokenAsyncErrors.Unauthorized);
        }

        ClaimsPrincipal claimPrincipal = _jwtProvider.GetClaimsPrincipalFromExpiredToken(oldToken);

        var userId = claimPrincipal.FindFirstValue(JwtRegisteredClaimNames.Sub);

        if (userId is null)
        {
            return Result.Failure<RefreshTokenAsyncResponse>(RefreshTokenAsyncErrors.Unauthorized);
        }

        User? user = await _userRepository
            .GetUserByIdAsync(
                int.Parse(userId),
                cancellationToken);

        if (user is null ||
            user.RefreshToken != httpContext.Request.Cookies["refresh-token"] ||
            user.RefreshTokenExpires < DateTime.Now)
        {
            return Result.Failure<RefreshTokenAsyncResponse>(RefreshTokenAsyncErrors.Unauthorized);
        }

        string newToken = _jwtProvider.Generate(user);

        user.GenerateRefreshToken(httpContext);

        RefreshTokenAsyncResponse res = new(newToken);

        return Result.Success(res);
    }
}
