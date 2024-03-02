using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetUserByIdWithAddressListAsync;

internal sealed record GetUserAddressListByIdAsyncQuery(int Id)
    : IRequest<Result<IReadOnlyCollection<AddressResponse>>>;
