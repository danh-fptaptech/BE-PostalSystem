using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Services.Users.Query.GetAddressListByUserIdAsync;

public sealed record AddressResponse(
    string Name,
    string PhoneNumber,
    string Address,
    string City,
    string District,
    string Ward,
    string PostalCode,
    ETypeInfo TypeInfo);
