using MediatR;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetAddressListByUserIdAsync;

internal sealed class GetAddressListByUserIdAsyncQueryHandler(
    IUserRepository userRepository,
    IHttpContextAccessor httpContextAccessor)
    : IRequestHandler<GetAddressListByUserIdAsyncQuery, Result<IReadOnlyCollection<AddressResponse>>>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public async Task<Result<IReadOnlyCollection<AddressResponse>>> Handle(
        GetAddressListByUserIdAsyncQuery query,
        CancellationToken cancellationToken)
    {
        var httpContext = _httpContextAccessor.HttpContext!;

        string? subClaim = subClaim = httpContext.User.FindFirstValue(JwtRegisteredClaimNames.Sub);

        // check not have policy, role, permission and check sub claim in jwt is diff from query params
        if (true && subClaim != query.Id.ToString())
        {
            return Result.Failure<IReadOnlyCollection<AddressResponse>>(GetAddressListByUserIdAsyncErrors.Unauthorized);
        }

        User? user = await _userRepository
            .GetUserByIdWithAddressListAsync(query.Id, cancellationToken);

        if (user == null)
        {
            return Result.Failure<IReadOnlyCollection<AddressResponse>>(GetAddressListByUserIdAsyncErrors.NotFound);
        }

        IReadOnlyCollection<AddressResponse> addressList = user
            .Customers
            .Select(c => new AddressResponse(
                c.Name,
                c.PhoneNumber,
                c.Address,
                c.City,
                c.District,
                c.Ward,
                c.PostalCode,
                c.TypeInfo))
            .ToList();

        return Result.Success(addressList);
    }
}
