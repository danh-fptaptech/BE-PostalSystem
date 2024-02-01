using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.RegisterUserAsync;

internal class RegisterUserAsyncHandler(
    IUserRepository userRepository,
    IUnitOfWork unitOfWork,
    IHashProvider hashProvider)
    : IRequestHandler<RegisterUserAsyncCommand, string>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IHashProvider _hashProvider = hashProvider;

    public async Task<string> Handle(RegisterUserAsyncCommand command, 
        CancellationToken cancellationToken)
    {
        User? user = await _userRepository
            .GetUserByEmailAsync(command.Email, cancellationToken);
        
        if (user is not null)
        {
            return null;
        }

        string hashedPassword = _hashProvider.Hash(command.Password);

        User newUser = User.RegisterUser(
            command.FullName, 
            command.Email,
            hashedPassword);

        await _userRepository.AddUser(newUser, cancellationToken);

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        // jwt and login
        return newUser.Email;
    }
}
