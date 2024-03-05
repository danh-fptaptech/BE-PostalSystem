using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Services.Users.Command.AddUserAddressAsync;

public sealed record AddUserAddressAsyncRequest(
    string Name,
    string PhoneNumber,
    string Address,
    string City,
    string District,
    string Ward,
    string PostalCode,
    ETypeInfo TypeInfo);
