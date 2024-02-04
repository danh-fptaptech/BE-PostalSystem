using MediatR;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.RevokeTokenAsync;

internal class RevokeTokenAsyncHandler(
    IHttpContextAccessor httpContextAccessor,
    IUserRepository userRepository,
    IUnitOfWork unitOfWork)
    : IRequestHandler<RevokeTokenAsyncCommand, bool>
{
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<bool> Handle(RevokeTokenAsyncCommand request, CancellationToken cancellationToken)
    {
        var httpContext = _httpContextAccessor.HttpContext;

        if (httpContext == null)
        {
            // 500
            return false;
        }

        string? userId = httpContext
            .User
            .FindFirstValue(JwtRegisteredClaimNames.Sub);

        if (userId is null)
        {
            //Unauthorized
            return false;
        }

        User? user = await _userRepository.GetUserByIdAsync(
            int.Parse(userId), cancellationToken);

        if (user is null)
        {
            //Unauthorized
            return false;
        }

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        return true;
    }
}
