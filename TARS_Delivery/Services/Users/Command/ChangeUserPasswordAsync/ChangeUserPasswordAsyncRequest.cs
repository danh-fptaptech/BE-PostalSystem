namespace TARS_Delivery.Services.Users.Command.ChangeUserPasswordAsync;

public sealed record ChangeUserPasswordAsyncRequest(string OldPassword, string NewPassword);
