namespace TARS_Delivery.Services.Users.Command.RegisterUserAsync;

public sealed record RegisterUserAsyncRequest(string FullName, string Email, string Phone, string Password);
