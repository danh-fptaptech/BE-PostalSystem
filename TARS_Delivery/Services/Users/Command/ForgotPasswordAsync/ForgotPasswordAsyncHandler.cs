using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;
using TARS_Delivery.UnitOfWork;
using static System.Net.WebRequestMethods;

namespace TARS_Delivery.Services.Users.Command.ForgotPasswordAsync;

internal class ResetPasswordAsyncHandler(
    IUserRepository userRepository,
    IMailProvider mailProvider,
    IUnitOfWork unitOfWork)
    : IRequestHandler<ForgotPasswordAsyncCommand, Result>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IMailProvider _mailProvider = mailProvider;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result> Handle(ForgotPasswordAsyncCommand command, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetUserByEmailAsync(command.Email, cancellationToken);

        if (user == null)
        {
            return Result.Failure(ResetPasswordAsyncErrors.NotFound);
        }

        string token = user.GeneratePasswordResetToken();

        await Task.WhenAll(
            _mailProvider.Send(
                command.Email,
                "Verify Your Email",
                $"Click url: http://localhost:3000/reset-password/{token}", cancellationToken),
            _unitOfWork.SaveChangeAsync(cancellationToken));

        return Result.Success();
    }
}
