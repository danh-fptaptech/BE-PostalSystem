using TARS_Delivery.Models.Enums;
using TARS_Delivery.Services.Users.Query.GetAddressListByUserIdAsync;
using TARS_Delivery.Services.Users.Query.GetUsersAsync;

namespace TARS_Delivery.Services.Users.Query.GetUsersWithAddressListAsync;

internal record UserWithAddressListResponse(
    int Id, 
    string Fullname, 
    string Email, 
    string Phone, 
    string? Avatar, 
    EStatusData Status, 
    IReadOnlyCollection<AddressResponse> Addresses) 
    : UserResponse(Id, Fullname, Email, Phone, Avatar, Status);
