using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Command.RefreshTokenAsync;

public sealed record RefreshTokenAsyncCommand : IRequest<Result<RefreshTokenAsyncResponse>>;
