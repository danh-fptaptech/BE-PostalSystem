using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Command.ResetPasswordAsync;

internal static class ResetPasswordAsyncErrors
{
    public static Error NotFound = new(nameof(NotFound), "Not found.");
}
