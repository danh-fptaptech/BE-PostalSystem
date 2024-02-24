using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.RegisterUserAsync;

internal sealed record RegisterUserAsyncCommand(
    string FullName, 
    string Email, 
    string Phone,
    string Password,
    string Avatar) 
        : IRequest<Result>;
