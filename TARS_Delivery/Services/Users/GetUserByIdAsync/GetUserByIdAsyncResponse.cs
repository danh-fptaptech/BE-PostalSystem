using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Services.Users.GetUserByIdAsync;

internal sealed record GetUserByIdAsyncResponse(
    string Fullname,
    string Email,
    string Phone,
    string Avatar,
    int Id,
    EStatusData Status);
