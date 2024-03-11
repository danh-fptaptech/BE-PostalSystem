namespace TARS_Delivery.Services.Users.Query.GetSenderAddressListByUserIdAsync;

internal sealed record SenderAddressResponse(
    string Name,
    string PhoneNumber,
    string Address,
    string City,
    string District,
    string Ward,
    string PostalCode);