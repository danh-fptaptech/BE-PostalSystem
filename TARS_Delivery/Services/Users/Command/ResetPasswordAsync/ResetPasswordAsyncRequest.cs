namespace TARS_Delivery.Services.Users.Command.ResetPasswordAsync;

public sealed record ResetPasswordAsyncRequest(string Password, string Token);
