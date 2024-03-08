using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.Command.ResetPasswordAsync;

internal class ResetPasswordAsyncHandler(
    IUserRepository userRepository,
    IHashProvider hashProvider,
    IUnitOfWork unitOfWork)
    : IRequestHandler<ResetPasswordAsyncCommand, Result>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IHashProvider _hashProvider = hashProvider;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result> Handle(ResetPasswordAsyncCommand command, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetUserByPasswordResetTokenAsync(command.Token, cancellationToken);

        if (user == null)
        {
            return Result.Failure(ResetPasswordAsyncErrors.NotFound);
        }

        string password = _hashProvider.Hash(command.Password);

        user.ResetPassword(password);

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        return Result.Success();
    }
}
