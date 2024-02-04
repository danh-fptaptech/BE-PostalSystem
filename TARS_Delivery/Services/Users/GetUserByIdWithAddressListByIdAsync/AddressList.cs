using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Services.Users.GetUserByIdWithAddressListByIdAsync;

public sealed record AddressList(
    string Name,
    string PhoneNumber,
    string Address,
    string City,
    string District,
    string Ward,
    ETypeInfo TypeInfo);
