using MediatR;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.Command.RevokeTokenAsync;

internal class RevokeTokenAsyncHandler(
    IHttpContextAccessor httpContextAccessor,
    IUserRepository userRepository,
    IUnitOfWork unitOfWork)
    : IRequestHandler<RevokeTokenAsyncCommand, Result>
{
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result> Handle(
        RevokeTokenAsyncCommand command,
        CancellationToken cancellationToken)
    {
        var httpContext = _httpContextAccessor.HttpContext!;

        string? userId = httpContext
            .User
            .FindFirstValue(JwtRegisteredClaimNames.Sub);

        if (userId is null)
        {
            return Result.Failure(VerifyUserMailAsyncErrors.Unauthorized);
        }

        User? user = await _userRepository.GetUserByIdAsync(
            int.Parse(userId), cancellationToken);

        if (user is null)
        {
            return Result.Failure(VerifyUserMailAsyncErrors.Unauthorized);
        }

        user.RevokeToken();

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        return Result.Success();
    }
}
