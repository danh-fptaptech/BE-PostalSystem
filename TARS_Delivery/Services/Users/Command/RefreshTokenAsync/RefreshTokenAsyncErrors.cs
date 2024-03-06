using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Command.RefreshTokenAsync;

internal static class RefreshTokenAsyncErrors
{
    public static Error Unauthorized = new(nameof(Unauthorized), "You can't access this.");
}
