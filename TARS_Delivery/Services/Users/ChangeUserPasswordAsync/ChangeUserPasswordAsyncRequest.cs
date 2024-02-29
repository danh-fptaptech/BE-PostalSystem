namespace TARS_Delivery.Services.Users.ChangeUserPasswordAsync;

public sealed record ChangeUserPasswordAsyncRequest(string OldPassword, string NewPassword);
