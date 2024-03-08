using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Command.ChangeStatusAsync;

internal record ChangeStatusAsyncCommand(int Id) : IRequest<Result>;
