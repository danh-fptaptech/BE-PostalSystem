using MediatR;

namespace TARS_Delivery.Services.Users.ChangeUserPasswordAsync;

internal sealed record ChangeUserPasswordAsyncCommand(int Id, string OldPassword, string NewPassword) : IRequest<bool>;
