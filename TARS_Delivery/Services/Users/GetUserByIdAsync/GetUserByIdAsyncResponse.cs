namespace TARS_Delivery.Services.Users.GetUserByIdAsync;

internal sealed record GetUserByIdAsyncResponse(
    string Fullname,
    string Email,
    string Phone,
    string Avatar);
