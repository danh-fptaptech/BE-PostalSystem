using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.ForgotPasswordAsync;

internal static class ForgotPasswordAsyncErrors
{
    public static Error NotFound = new(nameof(NotFound), "Not found this user.");
}
