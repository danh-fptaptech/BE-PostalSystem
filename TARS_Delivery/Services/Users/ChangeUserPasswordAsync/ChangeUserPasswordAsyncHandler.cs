using MediatR;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;
using TARS_Delivery.UnitOfWork;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TARS_Delivery.Services.Users.ChangeUserPasswordAsync;

internal sealed class ChangeUserPasswordAsyncHandler(
    IUserRepository userRepository,
    IHashProvider hashProvider,
    IUnitOfWork unitOfWork,
    IHttpContextAccessor httpContextAccessor) 
    : IRequestHandler<ChangeUserPasswordAsyncCommand, bool>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IHashProvider _hashProvider = hashProvider;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public async Task<bool> Handle(ChangeUserPasswordAsyncCommand command, 
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
            return false;
        }

        User? user = await _userRepository.GetUserByIdAsync(
            command.Id, cancellationToken);

        if (user == null)
        {
            return false;
        }
        
        if (!_hashProvider.Verify(command.OldPassword, user.Password))
        {
            return false;
        }

        string newPassword = _hashProvider.Hash(command.NewPassword);

        user.ChangePassword(newPassword);

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        return true;
    }
}
