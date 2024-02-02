using MediatR;
using TARS_Delivery.Services.Users.GetUserByIdWithAddressListByIdAsync;

namespace TARS_Delivery.Services.Users.GetUserByIdWithAddressListAsync;

internal record GetUserAddressListByIdAsyncQuery(int Id) 
    : IRequest<IReadOnlyCollection<AddressList>>;
