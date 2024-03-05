using MediatR;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetUserByIdAsync;

internal sealed class GetUserByIdAsyncHandler(
    IUserRepository userRepository,
    IHttpContextAccessor httpContextAccessor)
    : IRequestHandler<GetUserByIdAsyncQuery, Result<GetUserByIdAsyncResponse>>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public async Task<Result<GetUserByIdAsyncResponse>> Handle(
        GetUserByIdAsyncQuery query,
        CancellationToken cancellationToken)
    {
        var httpContext = _httpContextAccessor.HttpContext!;

        string? subClaim = httpContext.User.FindFirstValue(JwtRegisteredClaimNames.Sub);

        // check not have policy, role, permission and check sub claim in jwt is diff from query params
        if (true && subClaim != query.Id.ToString())
        {
            return Result.Failure<GetUserByIdAsyncResponse>(GetUserAddressListByIdAsyncErrors.Unauthorized);
        }

        User? user = await _userRepository
            .GetUserByIdAsync(query.Id, cancellationToken);

        if (user is null)
        {
            return Result.Failure<GetUserByIdAsyncResponse>(GetUserAddressListByIdAsyncErrors.NotFound);
        }

        GetUserByIdAsyncResponse response = new(
            user.Fullname,
            user.Email,
            user.Phone,
            user.Avatar,
            user.Id,
            user.Status);

        return Result.Success(response);

    }
}
