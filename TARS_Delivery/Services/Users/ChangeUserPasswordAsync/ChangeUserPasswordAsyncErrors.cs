using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.ChangeUserPasswordAsync;

internal static class GetUserByIdAsyncErrors
{
    public static Error Unauthorized = new(nameof(Unauthorized), "You can't access this.");

    public static Error NotFound = new(nameof(NotFound), "Not found this user.");

    public static Error IncorrectPassword = new(nameof(IncorrectPassword), "Password is incorrect.");
}
