using MediatR;
using TARS_Delivery.Repositories;
using TARS_Delivery.Services.Users.Query.GetAddressListByUserIdAsync;
using TARS_Delivery.Services.Users.Query.GetUsersWithPackagesAsync;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetUsersWithAllAsync;

internal class GetUsersWithAllAsyncHandler(IUserRepository userRepository)
    : IRequestHandler<GetUsersWithAllAsyncQuery, Result<IReadOnlyCollection<UserWithAllResponse>>>
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<Result<IReadOnlyCollection<UserWithAllResponse>>> Handle(
        GetUsersWithAllAsyncQuery query, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetUsersWithAllAsync(cancellationToken);

        IReadOnlyCollection<UserWithAllResponse> result = users
                .Select(u => new UserWithAllResponse(
                    u.Id, u.Fullname, u.Email, u.Phone, u.Avatar, u.Status,
                    u.Packages.Select(p => new PackageResponse(
                        p.Id,
                        p.TrackingCode,
                        p.NameFrom,
                        p.AddressFrom,
                        p.PostalCodeFrom,
                        p.NameTo,
                        p.AddressTo,
                        p.PostalCodeTo,
                        p.PackageSize,
                        p.PackageNote,
                        p.TotalFee,
                        p.FeeCustomId,
                        p.Step,
                        p.Status))
                    .ToList(),
                    u.Customers.Select(c => new AddressResponse(
                        c.Name,
                        c.PhoneNumber,
                        c.Address,
                        c.City,
                        c.District,
                        c.Ward,
                        c.PostalCode,
                        c.TypeInfo))
                    .ToList()))
                .ToList();

        return Result.Success(result);
    }
}
