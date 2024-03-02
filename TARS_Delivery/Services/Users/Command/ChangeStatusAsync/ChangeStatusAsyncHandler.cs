using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.Command.ChangeStatusAsync;

internal class ChangeStatusAsyncHandler(IUserRepository userRepository, IUnitOfWork unitOfWork) 
    : IRequestHandler<ChangeStatusAsyncCommand, Result>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result> Handle(ChangeStatusAsyncCommand command, 
        CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetUserByIdAsync(command.Id, cancellationToken);

        if (user == null)
        {
            return Result.Failure(ChangeStatusAsyncErrors.NotFound);
        }

        user.ChangeStatus();

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        return Result.Success();
    }
}
