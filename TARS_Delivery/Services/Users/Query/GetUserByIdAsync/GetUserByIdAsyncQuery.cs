using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetUserByIdAsync;

internal sealed record GetUserByIdAsyncQuery(int Id) :
    IRequest<Result<GetUserByIdAsyncResponse>>;
