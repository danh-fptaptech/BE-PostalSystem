using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetUserByIdWithAddressListAsync;

internal static class GetUserByIdWithAddressListAsyncErrors
{
    public static Error Unauthorized = new(nameof(Unauthorized), "You can't access this.");

    public static Error NotFound = new(nameof(NotFound), "Not found this user.");
}
