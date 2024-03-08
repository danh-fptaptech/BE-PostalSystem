using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;
using TARS_Delivery.Services.Users.Command.UpdateUserProfileByIdAsync;
using TARS_Delivery.Shared;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.Command.UpdateUserByIdAsync;

internal class UpdateUserByIdAsyncHandler(IUserRepository userRepository, IUnitOfWork unitOfWork) : IRequestHandler<UpdateUserByIdAsyncCommand, Result>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result> Handle(UpdateUserByIdAsyncCommand command, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetUserByIdAsync(command.Id, cancellationToken);

        if (user == null)
        {
            return Result.Failure(UpdateUserByIdAsyncErrors.NotFound);
        }

        user.UpdateProfile(command.Fullname, command.Phone);

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        return Result.Success();
    }
}
