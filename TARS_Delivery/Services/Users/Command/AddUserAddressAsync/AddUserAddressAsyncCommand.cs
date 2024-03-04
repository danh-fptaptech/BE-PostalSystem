using MediatR;
using TARS_Delivery.Models.Enums;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Command.AddUserAddressAsync;

internal sealed record AddUserAddressAsyncCommand(
    int UserId,
    string Name,
    string PhoneNumber,
    string Address,
    string City,
    string District,
    string Ward,
    string PostalCode,
    ETypeInfo TypeInfo) : IRequest<Result>;
