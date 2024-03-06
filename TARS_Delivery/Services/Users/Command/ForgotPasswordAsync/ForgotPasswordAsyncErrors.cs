using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Command.ForgotPasswordAsync;

internal static class ResetPasswordAsyncErrors
{
    public static Error NotFound = new(nameof(NotFound), "Not found this user.");
}
