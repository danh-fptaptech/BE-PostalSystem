using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.Command.VerifyUserMailAsync;

internal class VerifyUserMailAsyncHandler(
    IUserRepository userRepository,
    IJwtProvider jwtProvider,
    IUnitOfWork unitOfWork,
    IUserRegistrationInfoRepository userRegistrationInfoRepository,
    IHttpContextAccessor httpContextAccessor)
    : IRequestHandler<VerifyUserMailAsyncCommand, Result<VerifyUserMailAsyncResponse>>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IJwtProvider _jwtProvider = jwtProvider;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IUserRegistrationInfoRepository _userRegistrationInfoRepository = userRegistrationInfoRepository;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public async Task<Result<VerifyUserMailAsyncResponse>> Handle(
        VerifyUserMailAsyncCommand command,
        CancellationToken cancellationToken)
    {
        var httpContext = _httpContextAccessor.HttpContext!;

        var userInfo = await _userRegistrationInfoRepository
            .GetUserRegistrationInfoByOtpAsync(
                command.Otp, cancellationToken);

        if (userInfo == null)
        {
            return Result.Failure<VerifyUserMailAsyncResponse>(VerifyUserMailAsyncErrors.IncorectOtp);
        }

        User user = userInfo.Register();

        user.GenerateRefreshToken(httpContext);

        await _userRepository.AddUser(user, cancellationToken);

        _userRegistrationInfoRepository.DeleteUserRegistrationInfo(userInfo);

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        string token = _jwtProvider.Generate(user);

        VerifyUserMailAsyncResponse res = new(token);

        return Result.Success(res);
    }
}
