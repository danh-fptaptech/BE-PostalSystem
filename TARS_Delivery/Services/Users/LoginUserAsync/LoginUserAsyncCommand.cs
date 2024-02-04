using MediatR;

namespace TARS_Delivery.Services.Users.LoginUserAsync;

internal sealed class LoginUserAsyncCommand(string userId, string password) 
    : IRequest<string>
{
    public Type Type { get; private init; } = userId.Contains('@') 
        ? Type.Email 
        : Type.Phone;

    public string UserId { get; private init; } = userId;

    public string Password { get; private init; } = password;
}
