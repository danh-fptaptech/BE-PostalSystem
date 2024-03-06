using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Command.LoginUserAsync;

internal sealed class LoginUserAsyncCommand(string userId, string password)
    : IRequest<Result<LoginUserAsyncResponse>>
{
    public Type Type { get; private init; } = userId.Contains('@')
        ? Type.Email
        : Type.Phone;

    public string UserId { get; private init; } = userId;

    public string Password { get; private init; } = password;
}
