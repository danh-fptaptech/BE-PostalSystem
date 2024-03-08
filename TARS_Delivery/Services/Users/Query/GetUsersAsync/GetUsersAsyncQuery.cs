using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetUsersAsync;

internal record GetUsersAsyncQuery : IRequest<Result<IReadOnlyCollection<UserResponse>>>;