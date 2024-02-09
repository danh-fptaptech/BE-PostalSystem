using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.VerifyUserMailAsync;

internal record VerifyUserMailAsyncCommand(string Otp) : IRequest<Result<string>>;
