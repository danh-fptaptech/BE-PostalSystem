using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetUsersWithAddressListAsync;

internal record GetUsersWithAddressListAsyncQuery 
    : IRequest<Result<IReadOnlyCollection<UserWithAddressListResponse>>>;
