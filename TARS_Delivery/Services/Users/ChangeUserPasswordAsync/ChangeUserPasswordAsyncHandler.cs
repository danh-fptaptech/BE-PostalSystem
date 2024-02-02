using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.ChangeUserPasswordAsync;

internal class ChangeUserPasswordAsyncHandler(
    IUserRepository userRepository,
    IHashProvider hashProvider,
    IUnitOfWork unitOfWork) 
    : IRequestHandler<ChangeUserPasswordAsyncCommand, bool>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IHashProvider _hashProvider = hashProvider;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<bool> Handle(ChangeUserPasswordAsyncCommand command, 
        CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetUserByIdAsync(
            command.Id, cancellationToken);

        if (user == null)
        {
            return false;
        }
        
        if (!_hashProvider.Verify(command.OldPassword, user.Password))
        {
            return false;
        }

        string newPassword = _hashProvider.Hash(command.NewPassword);

        user.ChangePassword(newPassword);

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        return true;
    }
}
