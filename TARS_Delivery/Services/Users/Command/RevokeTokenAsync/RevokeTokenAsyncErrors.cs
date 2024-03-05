using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Command.RevokeTokenAsync;

internal static class VerifyUserMailAsyncErrors
{
    public static Error Unauthorized = new(nameof(Unauthorized), "You can't access this.");
}
