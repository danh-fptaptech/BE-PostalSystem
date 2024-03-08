using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetReceiverAddressListByUserIdAsync;

internal sealed record GetReceiverAddressListByUserIdAsyncQuery(int Id)
    : IRequest<Result<IReadOnlyCollection<SenderAddressResponse>>>;
