using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.RevokeTokenAsync;

internal record RevokeTokenAsyncCommand : IRequest<Result>;
