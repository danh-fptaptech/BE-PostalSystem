using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.VerifyUserMailAsync;

internal static class VerifyUserMailAsyncErrors
{
    public static Error IncorectOtp = new(nameof(IncorectOtp), "Otp is incorect or expired.");
}
