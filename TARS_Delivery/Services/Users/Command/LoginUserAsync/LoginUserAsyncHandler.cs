using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.Command.LoginUserAsync;

internal sealed class LoginUserAsyncHandler(
    IUserRepository userRepository,
    IUnitOfWork unitOfWork,
    IHashProvider hashProvider,
    IJwtProvider jwtProvider,
    IHttpContextAccessor httpContextAccessor)
    : IRequestHandler<LoginUserAsyncCommand, Result<LoginUserAsyncResponse>>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IHashProvider _hashProvider = hashProvider;
    private readonly IJwtProvider _jwtProvider = jwtProvider;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public async Task<Result<LoginUserAsyncResponse>> Handle(
        LoginUserAsyncCommand command,
        CancellationToken cancellationToken)
    {
        User? user;

        if (command.Type == Type.Email)
        {
            user = await _userRepository.GetUserByEmailAsync(
                command.UserId, cancellationToken);
        }
        else
        {
            user = await _userRepository.GetUserByPhoneAsync(
                command.UserId, cancellationToken);
        }

        if (user is null)
        {
            return Result.Failure<LoginUserAsyncResponse>(LoginUserAsyncErrors.NotFound);
        }

        if (!_hashProvider.Verify(command.Password, user.Password))
        {
            return Result.Failure<LoginUserAsyncResponse>(LoginUserAsyncErrors.IncorrectPassword);
        }

        string token = _jwtProvider.Generate(user);

        var httpContext = _httpContextAccessor.HttpContext!;

        user.GenerateRefreshToken(httpContext);

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        LoginUserAsyncResponse res = new(user.Id, user.Fullname, user.Email, user.Phone, user.Avatar, token);

        return Result.Success(res);
    }
}
