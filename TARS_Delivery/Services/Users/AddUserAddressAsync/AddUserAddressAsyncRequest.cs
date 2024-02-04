using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Services.Users.AddUserAddressAsync;

public sealed record AddUserAddressAsyncRequest(
    string Name,
    string PhoneNumber,
    string Address,
    string City,
    string District,
    string Ward,
    ETypeInfo TypeInfo);
