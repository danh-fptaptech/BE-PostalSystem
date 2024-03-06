using MediatR;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.Command.ChangeUserPasswordAsync;

internal sealed class ChangeUserPasswordAsyncHandler(
    IUserRepository userRepository,
    IHashProvider hashProvider,
    IUnitOfWork unitOfWork,
    IHttpContextAccessor httpContextAccessor)
    : IRequestHandler<ChangeUserPasswordAsyncCommand, Result>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IHashProvider _hashProvider = hashProvider;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public async Task<Result> Handle(ChangeUserPasswordAsyncCommand command,
        CancellationToken cancellationToken)
    {
        var httpContext = _httpContextAccessor.HttpContext;
        string? subClaim = string.Empty;

        if (httpContext is not null)
        {
            subClaim = httpContext.User.FindFirstValue(JwtRegisteredClaimNames.Sub);
        }

        // check not have policy, role, permission
        // check not have policy, role, permission and check sub claim in jwt is diff from query params
        if (true && subClaim != command.Id.ToString())
        {
            return Result.Failure(GetUserByIdAsyncErrors.Unauthorized);
        }

        User? user = await _userRepository.GetUserByIdAsync(
            command.Id, cancellationToken);

        if (user == null)
        {
            return Result.Failure(GetUserByIdAsyncErrors.NotFound);
        }

        if (!_hashProvider.Verify(command.OldPassword, user.Password))
        {
            return Result.Failure(GetUserByIdAsyncErrors.IncorrectPassword);
        }

        string newPassword = _hashProvider.Hash(command.NewPassword);

        user.ChangePassword(newPassword);

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        return Result.Success();
    }
}
