using MediatR;
using TARS_Delivery.Repositories;
using TARS_Delivery.Services.Users.Query.GetAddressListByUserIdAsync;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetUsersWithAddressListAsync;

internal class GetUsersWithAddressListAsyncHandler(IUserRepository userRepository)
    : IRequestHandler<GetUsersWithAddressListAsyncQuery,
       Result<IReadOnlyCollection<UserWithAddressListResponse>>>
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<Result<IReadOnlyCollection<UserWithAddressListResponse>>> Handle(
        GetUsersWithAddressListAsyncQuery query, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetUsersWithAddressListAsync(cancellationToken);

        IReadOnlyCollection<UserWithAddressListResponse> result = users
                .Select(u => new UserWithAddressListResponse(
                    u.Id, u.Fullname, u.Email, u.Phone, u.Avatar, u.Status,
                    u.Customers.Select(c => new AddressResponse(
                        c.Name, c.PhoneNumber, c.Address, c.City, c.District, c.Ward, c.PostalCode, c.TypeInfo))
                    .ToList()))
                .ToList();

        return Result.Success(result);
    }
}
