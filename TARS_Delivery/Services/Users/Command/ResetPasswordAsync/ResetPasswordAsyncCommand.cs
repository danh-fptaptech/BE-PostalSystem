using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Command.ResetPasswordAsync;

internal sealed record ResetPasswordAsyncCommand(string Password, string Token) : IRequest<Result>;
