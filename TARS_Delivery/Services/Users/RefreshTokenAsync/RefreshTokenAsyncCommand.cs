using MediatR;

namespace TARS_Delivery.Services.Users.RefreshTokenAsync;

public sealed record RefreshTokenAsyncCommand : IRequest<string>;
