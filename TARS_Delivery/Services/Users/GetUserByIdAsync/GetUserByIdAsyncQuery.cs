using MediatR;

namespace TARS_Delivery.Services.Users.GetUserByIdAsync;

internal sealed record GetUserByIdAsyncQuery(int Id) : 
    IRequest<RegisterUserAsyncResponse>;
