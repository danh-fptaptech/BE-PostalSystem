using MediatR;

namespace TARS_Delivery.Services.Users.GetUserByIdAsync;

internal record GetUserByIdAsyncQuery(int Id) : 
    IRequest<RegisterUserAsyncResponse>;
