using MediatR;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.Users.GetUserByIdAsync;

internal sealed class GetUserByIdAsyncHandler(
    IUserRepository userRepository,
    IHttpContextAccessor httpContextAccessor) 
    : IRequestHandler<GetUserByIdAsyncQuery, RegisterUserAsyncResponse>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public async Task<RegisterUserAsyncResponse> Handle(
        GetUserByIdAsyncQuery query, 
        CancellationToken cancellationToken)
    {
        var httpContext = _httpContextAccessor.HttpContext;
        string? subClaim = string.Empty;

        if (httpContext is not null)
        {
            subClaim = httpContext.User.FindFirstValue(JwtRegisteredClaimNames.Sub);
        }

        // check not have policy, role, permission and check sub claim in jwt is diff from query params
        if (true && subClaim != query.Id.ToString())
        {
            return null;
        }

        User? user = await _userRepository
            .GetUserByIdAsync(query.Id, cancellationToken);

        if (user is null)
        {
            // notfound
            return null;
        }

        return new RegisterUserAsyncResponse(
            user.Fullname, 
            user.Email, 
            user.Phone, 
            user.Avatar);
    }
}
