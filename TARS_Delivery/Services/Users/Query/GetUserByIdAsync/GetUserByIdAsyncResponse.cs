using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Services.Users.Query.GetUserByIdAsync;

internal sealed record GetUserByIdAsyncResponse(
    string Fullname,
    string Email,
    string Phone,
    string? Avatar,
    int Id,
    EStatusData Status);
