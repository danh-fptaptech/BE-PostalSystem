using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetSenderAddressListByUserIdAsync;

internal sealed record GetSenderAddressListByUserIdAsyncQuery(int Id)
    : IRequest<Result<IReadOnlyCollection<SenderAddressResponse>>>;
