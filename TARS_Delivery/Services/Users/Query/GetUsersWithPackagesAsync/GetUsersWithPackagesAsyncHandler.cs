using MediatR;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetUsersWithPackagesAsync;

internal class GetUsersWithPackagesAsyncHandler(IUserRepository userRepository)
    : IRequestHandler<GetUsersWithPackagesAsyncQuery, Result<IReadOnlyCollection<UserWithPackagesResponse>>>
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<Result<IReadOnlyCollection<UserWithPackagesResponse>>> Handle(
        GetUsersWithPackagesAsyncQuery query, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetUsersWithPackagesAsync(cancellationToken);

        IReadOnlyCollection<UserWithPackagesResponse> result = users
                .Select(u => new UserWithPackagesResponse(
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
                    .ToList()))
                .ToList();

        return Result.Success(result);
    }
}
