using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Command.UpdateUserProfileByIdAsync;

internal record UpdateUserByIdAsyncCommand(int Id, string Fullname, string Email, string Phone) : IRequest<Result>;
