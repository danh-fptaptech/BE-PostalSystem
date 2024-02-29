using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.RefreshTokenAsync;

public sealed record RefreshTokenAsyncCommand : IRequest<Result<string>>;
