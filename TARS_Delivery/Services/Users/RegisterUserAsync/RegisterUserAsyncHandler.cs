using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.RegisterUserAsync;

internal class RegisterUserAsyncHandler(
    IUserRepository userRepository,
    IUnitOfWork unitOfWork,
    IHashProvider hashProvider,
    IJwtProvider jwtProvider,
    IMailProvider mailProvider)
    : IRequestHandler<RegisterUserAsyncCommand, string>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IHashProvider _hashProvider = hashProvider;
    private readonly IJwtProvider _jwtProvider = jwtProvider;
    private readonly IMailProvider _mailProvider = mailProvider;

    public async Task<string> Handle(
        RegisterUserAsyncCommand command, 
        CancellationToken cancellationToken)
    {
        bool IsUserExisting = await _userRepository
            .CheckUserIsExisting(
                command.Email,
                command.Phone, 
                cancellationToken);
        
        if (IsUserExisting)
        {
            return null;
        }

        string hashedPassword = _hashProvider.Hash(command.Password);

        User newUser = User.Register(
            command.FullName, 
            command.Email,
            command.Phone,
            hashedPassword);

        await _userRepository.AddUser(newUser, cancellationToken);

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        string token = _jwtProvider.Generate(newUser);

        return token;
    }
}
