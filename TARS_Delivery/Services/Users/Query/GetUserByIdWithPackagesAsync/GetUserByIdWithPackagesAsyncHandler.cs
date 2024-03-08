using MediatR;
using TARS_Delivery.Repositories;
using TARS_Delivery.Services.Users.Query.GetUsersWithPackagesAsync;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetUserByIdWithPackagesAsync;

internal class GetUserByIdWithPackagesAsyncHandler(IUserRepository userRepository)
    : IRequestHandler<GetUserByIdWithPackagesAsyncQuery, Result<UserWithPackagesResponse>>
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<Result<UserWithPackagesResponse>> Handle(
        GetUserByIdWithPackagesAsyncQuery query, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserByIdWithPackagesAsync(query.Id, cancellationToken);

        if (user == null)
        {
            return Result.Failure<UserWithPackagesResponse>(GetUserByIdWithPackagesAsyncErrors.NotFound);
        }
        UserWithPackagesResponse result = new(
            user.Id, 
            user.Fullname, 
            user.Email, 
            user.Phone, 
            user.Avatar, 
            user.Status, 
            user.Packages.Select(p => new PackageResponse(
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
                    .ToList());


        return Result.Success(result);
    }
}
