using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Services.Users.Query.GetUsersAsync;

internal record UserResponse(
    int Id, string Fullname, string Email, string Phone, string? Avatar, EStatusData Status);