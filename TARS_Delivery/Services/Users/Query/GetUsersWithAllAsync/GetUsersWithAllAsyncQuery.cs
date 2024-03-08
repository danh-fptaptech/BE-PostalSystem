using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetUsersWithAllAsync;

internal record GetUsersWithAllAsyncQuery : IRequest<Result<IReadOnlyCollection<UserWithAllResponse>>>;
