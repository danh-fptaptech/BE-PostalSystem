using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetAddressListByUserIdAsync;

internal sealed record GetAddressListByUserIdAsyncQuery(int Id)
    : IRequest<Result<IReadOnlyCollection<AddressResponse>>>;
