using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;
using static System.Net.WebRequestMethods;

namespace TARS_Delivery.Services.Users.ForgotPasswordAsync;

internal class ForgotPasswordAsyncHandler(IUserRepository userRepository, IMailProvider mailProvider)
    : IRequestHandler<ForgotPasswordAsyncCommand, Result>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IMailProvider _mailProvider = mailProvider;

    public async Task<Result> Handle(ForgotPasswordAsyncCommand command, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetUserByEmailAsync(command.Email, cancellationToken);
        
        if (user == null)
        {
            return Result.Failure(ForgotPasswordAsyncErrors.NotFound);
        }

        //_mailProvider.Send(command.Email, "Verify Your Email", otp, cancellationToken))

        return Result.Success();
    }
}
