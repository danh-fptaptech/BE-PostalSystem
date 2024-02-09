using MediatR;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;
using TARS_Delivery.Services.Users.GetUserAddressListByIdAsync;
using TARS_Delivery.Services.Users.GetUserByIdWithAddressListByIdAsync;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.GetUserByIdWithAddressListAsync;

internal sealed class GetUserAddressListByIdAsyncHandler(
    IUserRepository userRepository,
    IHttpContextAccessor httpContextAccessor)
    : IRequestHandler<GetUserAddressListByIdAsyncQuery, Result<IReadOnlyCollection<AddressList>>>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public async Task<Result<IReadOnlyCollection<AddressList>>> Handle(
        GetUserAddressListByIdAsyncQuery query, 
        CancellationToken cancellationToken)
    {
        var httpContext = _httpContextAccessor.HttpContext!;
       
        string? subClaim = subClaim = httpContext.User.FindFirstValue(JwtRegisteredClaimNames.Sub);

        // check not have policy, role, permission and check sub claim in jwt is diff from query params
        if (true && subClaim != query.Id.ToString())
        {
            return Result.Failure<IReadOnlyCollection<AddressList>>(GetUserAddressListByIdAsyncErrors.Unauthorized);
        }

        User? user = await _userRepository
            .GetUserByIdWithAddressListAsync(query.Id, cancellationToken);

        if (user == null)
        {
            return Result.Failure<IReadOnlyCollection<AddressList>>(GetUserAddressListByIdAsyncErrors.NotFound);
        }

        IReadOnlyCollection<AddressList> addressList = user
            .Customers
            .Select(c => new AddressList(
                c.Name, 
                c.PhoneNumber, 
                c.Address, 
                c.City, 
                c.District, 
                c.Ward, 
                c.TypeInfo))
            .ToList();

        return Result.Success(addressList);
    }
}
