using MediatR;
using TARS_Delivery.Services.Users.GetUserByIdWithAddressListByIdAsync;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.GetUserByIdWithAddressListAsync;

internal sealed record GetUserAddressListByIdAsyncQuery(int Id) 
    : IRequest<Result<IReadOnlyCollection<AddressList>>>;
