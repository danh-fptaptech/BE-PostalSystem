using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Command.RegisterUserAsync;

internal sealed record RegisterUserAsyncCommand(
    string FullName,
    string Email,
    string Phone,
    string Password)
        : IRequest<Result>;
