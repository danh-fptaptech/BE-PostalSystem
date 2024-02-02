using MediatR;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Services.Users.AddUserAddressAsync;

internal record AddUserAddressAsyncCommand(
    int UserId,
    string Name,
    string PhoneNumber,
    string Address,
    string City,
    string District,
    string Ward,
    ETypeInfo TypeInfo) : IRequest<bool>;
