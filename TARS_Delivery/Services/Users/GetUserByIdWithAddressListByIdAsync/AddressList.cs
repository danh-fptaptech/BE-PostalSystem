using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Services.Users.GetUserByIdWithAddressListByIdAsync;

public sealed record AddressList(
    string Name,
    string PhoneNumber,
    string Address,
    string City,
    string District,
    string Ward,
    ETypeInfo TypeInfo);
