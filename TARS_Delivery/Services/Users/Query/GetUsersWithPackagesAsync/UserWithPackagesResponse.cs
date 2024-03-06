using TARS_Delivery.Models.Enums;
using TARS_Delivery.Services.Users.Query.GetUsersAsync;

namespace TARS_Delivery.Services.Users.Query.GetUsersWithPackagesAsync;

internal record UserWithPackagesResponse(
    int Id,
    string Fullname,
    string Email,
    string Phone,
    string? Avatar,
    EStatusData Status,
    IReadOnlyCollection<PackageResponse> Packages)
    : UserResponse(Id, Fullname, Email, Phone, Avatar, Status);
