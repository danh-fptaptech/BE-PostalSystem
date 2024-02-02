using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.Users.LoginUserAsync;

internal class LoginUserAsynsHandler(
    IUserRepository userRepository,
    IHashProvider hashProvider,
    IJwtProvider jwtProvider)
    : IRequestHandler<LoginUserAsyncCommand, string>
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<string> Handle(
        LoginUserAsyncCommand command, 
        CancellationToken cancellationToken)
    {
        User? user = null;

        if (command.Type == Type.Email)
        {
            user = await _userRepository.GetUserByEmailAsync(
                command.UserId ,cancellationToken);
        }
        else
        {
            user = await _userRepository.GetUserByPhoneAsync(
                command.UserId, cancellationToken);
        }

        if (user is null)
        {
            return null;
        }

        if (!hashProvider.Verify(command.Password, user.Password))
        {
            return null;
        }

        string token = jwtProvider.Generate(user);

        return token;
    }
}
