using MediatR;
using TARS_Delivery.Models.Enum;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.AddUserAddressAsync;

internal sealed record AddUserAddressAsyncCommand(
    int UserId,
    string Name,
    string PhoneNumber,
    string Address,
    string City,
    string District,
    string Ward,
    ETypeInfo TypeInfo) : IRequest<Result>;
