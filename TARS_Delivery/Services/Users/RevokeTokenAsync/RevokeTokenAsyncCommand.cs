using MediatR;

namespace TARS_Delivery.Services.Users.RevokeTokenAsync;

internal record RevokeTokenAsyncCommand : IRequest<bool>;
