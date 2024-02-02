using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.AddUserAddressAsync;

internal class AddUserAddressAsyncHandler(
    IUserRepository userRepository,
    IUnitOfWork unitOfWork) 
    : IRequestHandler<AddUserAddressAsyncCommand, bool>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<bool> Handle(
        AddUserAddressAsyncCommand command,
        CancellationToken cancellationToken)
    {
        User? user = await _userRepository
            .GetUserByIdAsync(
                command.UserId, 
                cancellationToken);

        if (user is null)
        {
            return false;
        }

        // tim postal code
        string postalcode = "";

        user.AddCustomer(
            command.Name,
            command.PhoneNumber,
            command.Address,
            command.City,
            command.District,
            command.Ward,
            postalcode,
            command.TypeInfo);

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        return true;
    }
}
