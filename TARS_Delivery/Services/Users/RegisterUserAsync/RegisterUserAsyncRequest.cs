namespace TARS_Delivery.Services.Users.RegisterUserAsync;

public sealed record RegisterUserAsyncRequest(string FullName, string Email, string Phone, string Password, string Avatar);
