using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.Command.RegisterUserAsync;

internal class RegisterUserAsyncHandler(
    IUserRepository userRepository,
    IUnitOfWork unitOfWork,
    IHashProvider hashProvider,
    IMailProvider mailProvider,
    IOtpProvider otpProvider,
    IUserRegistrationInfoRepository userRegistrationInfoRepository)
    : IRequestHandler<RegisterUserAsyncCommand, Result>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IHashProvider _hashProvider = hashProvider;
    private readonly IMailProvider _mailProvider = mailProvider;
    private readonly IOtpProvider _otpProvider = otpProvider;
    private readonly IUserRegistrationInfoRepository _userRegistrationInfoRepository = userRegistrationInfoRepository;

    public async Task<Result> Handle(
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
            return Result.Failure(RegisterUserAsyncErrors.UniqueUser);
        }

        string hashedPassword = _hashProvider.Hash(command.Password);

        string otp = _otpProvider.Generate("0123456789", 6);

        UserRegistrationInfo userInfo = UserRegistrationInfo.Create(
            command.FullName, command.Email, hashedPassword, command.Phone, otp);

        await Task.WhenAll(
            _userRegistrationInfoRepository.AddUserRegistrationInfo(userInfo, cancellationToken),
            _mailProvider.Send(command.Email, "Verify Your Email", otp, cancellationToken));

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        return Result.Success();
    }
}
