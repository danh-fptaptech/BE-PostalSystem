using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Command.RegisterUserAsync;

internal static class RegisterUserAsyncErrors
{
    public static Error UniqueUser = new(nameof(UniqueUser), "Email or phone number is used.");
}
