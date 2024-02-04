namespace TARS_Delivery.Services.Users.GetUserByIdAsync;

internal sealed record RegisterUserAsyncResponse(
    string Fullname,
    string Email,
    string Phone,
    string Avatar);
