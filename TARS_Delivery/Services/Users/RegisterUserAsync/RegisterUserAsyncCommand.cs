using MediatR;

namespace TARS_Delivery.Services.Users.RegisterUserAsync;

internal sealed record RegisterUserAsyncCommand(
    string FullName, 
    string Email, 
    string Phone,
    string Password) 
        : IRequest<string>;
