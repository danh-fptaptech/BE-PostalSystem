using MediatR;

namespace TARS_Delivery.Services.Users.RegisterUserAsync;

internal record RegisterUserAsyncCommand(
    string FullName, 
    string Email, 
    string Password) 
        : IRequest<string>;
