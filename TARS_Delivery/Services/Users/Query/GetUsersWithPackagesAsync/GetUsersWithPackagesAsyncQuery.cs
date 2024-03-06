using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetUsersWithPackagesAsync;

internal record GetUsersWithPackagesAsyncQuery : IRequest<Result<IReadOnlyCollection<UserWithPackagesResponse>>>;
