using TARS_Delivery.Models.Enums;
using TARS_Delivery.Services.Users.Query.GetAddressListByUserIdAsync;
using TARS_Delivery.Services.Users.Query.GetUsersAsync;
using TARS_Delivery.Services.Users.Query.GetUsersWithPackagesAsync;

namespace TARS_Delivery.Services.Users.Query.GetUsersWithAllAsync;

internal record UserWithAllResponse(
    int Id,
    string Fullname,
    string Email,
    string Phone,
    string? Avatar,
    EStatusData Status,
    IReadOnlyCollection<PackageResponse> Packages,
    IReadOnlyCollection<AddressResponse> Addresses)
    : UserResponse(Id, Fullname, Email, Phone, Avatar, Status);
