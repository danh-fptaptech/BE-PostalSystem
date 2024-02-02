namespace TARS_Delivery.Services.Users.ChangeUserPasswordAsync;

public record ChangeUserPasswordAsyncRequest(string OldPassword, string NewPassword);
