using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.ResetPasswordAsync;

internal record ResetPasswordAsyncQuery(string Token) : IRequest<Result>;
