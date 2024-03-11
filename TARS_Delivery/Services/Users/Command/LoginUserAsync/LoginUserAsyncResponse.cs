namespace TARS_Delivery.Services.Users.Command.LoginUserAsync;

public record LoginUserAsyncResponse(
    int Id, string Fullname, string Email, string PhoneNumber, string? Avatar, string Token);
