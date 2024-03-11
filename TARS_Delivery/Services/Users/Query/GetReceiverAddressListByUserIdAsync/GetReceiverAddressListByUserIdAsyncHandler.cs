using MediatR;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetReceiverAddressListByUserIdAsync;

internal sealed class GetReceiverAddressListByUserIdAsyncHandler(
    IUserRepository userRepository,
    IHttpContextAccessor httpContextAccessor)
    : IRequestHandler<GetReceiverAddressListByUserIdAsyncQuery, Result<IReadOnlyCollection<SenderAddressResponse>>>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public async Task<Result<IReadOnlyCollection<SenderAddressResponse>>> Handle(
        GetReceiverAddressListByUserIdAsyncQuery query,
        CancellationToken cancellationToken)
    {
        var httpContext = _httpContextAccessor.HttpContext!;

        string? subClaim = subClaim = httpContext.User.FindFirstValue(JwtRegisteredClaimNames.Sub);

        // check not have policy, role, permission and check sub claim in jwt is diff from query params
        if (true && subClaim != query.Id.ToString())
        {
            return Result.Failure<IReadOnlyCollection<SenderAddressResponse>>(GetReceiverAddressListByUserIdAsyncErrors.Unauthorized);
        }

        User? user = await _userRepository
            .GetUserByIdWithAddressListAsync(query.Id, cancellationToken);

        if (user == null)
        {
            return Result.Failure<IReadOnlyCollection<SenderAddressResponse>>(GetReceiverAddressListByUserIdAsyncErrors.NotFound);
        }

        IReadOnlyCollection<SenderAddressResponse> addressList = user
            .Customers.Where(c => c.TypeInfo == ETypeInfo.Receiver)
            .Select(c => new SenderAddressResponse(
                c.Name,
                c.PhoneNumber,
                c.Address,
                c.City,
                c.District,
                c.Ward,
                c.PostalCode))
            .ToList();

        return Result.Success(addressList);
    }
}
