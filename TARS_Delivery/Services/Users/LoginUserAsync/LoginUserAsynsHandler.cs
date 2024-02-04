using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.LoginUserAsync;

internal sealed class LoginUserAsynsHandler(
    IUserRepository userRepository,
    IUnitOfWork unitOfWork,
    IHashProvider hashProvider,
    IJwtProvider jwtProvider,
    IHttpContextAccessor httpContextAccessor)
    : IRequestHandler<LoginUserAsyncCommand, string>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IHashProvider _hashProvider = hashProvider;
    private readonly IJwtProvider _jwtProvider = jwtProvider;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

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

        if (!_hashProvider.Verify(command.Password, user.Password))
        {
            return null;
        }

        string token = _jwtProvider.Generate(user);

        var httpContext = _httpContextAccessor.HttpContext;

        if (httpContext is null)
        {
            return "";
        }

        user.GenerateRefreshToken(httpContext);

        await _unitOfWork.SaveChangeAsync(cancellationToken);
        //
        return token;
    }
}
