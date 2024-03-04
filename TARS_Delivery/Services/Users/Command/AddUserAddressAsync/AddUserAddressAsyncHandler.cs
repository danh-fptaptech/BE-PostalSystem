using MediatR;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;
using TARS_Delivery.UnitOfWork;

namespace TARS_Delivery.Services.Users.Command.AddUserAddressAsync;

internal sealed class AddUserAddressAsyncHandler(
    IUserRepository userRepository,
    IUnitOfWork unitOfWork,
    IHttpContextAccessor httpContextAccessor)
    : IRequestHandler<AddUserAddressAsyncCommand, Result>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public async Task<Result> Handle(
        AddUserAddressAsyncCommand command,
        CancellationToken cancellationToken)
    {
        var httpContext = _httpContextAccessor.HttpContext!;

        string? subClaim = httpContext.User.FindFirstValue(JwtRegisteredClaimNames.Sub);

        // check not have policy, role, permission
        // check not have policy, role, permission and check sub claim in jwt is diff from query params
        if (true && subClaim != command.UserId.ToString())
        {
            return Result.Failure(ChangeUserPasswordAsyncErrors.Unauthorized);
        }

        User? user = await _userRepository
            .GetUserByIdAsync(
                command.UserId,
                cancellationToken);

        if (user is null)
        {
            return Result.Failure(ChangeUserPasswordAsyncErrors.NotFound);
        }

        user.AddCustomer(
            command.Name,
            command.PhoneNumber,
            command.Address,
            command.City,
            command.District,
            command.Ward,
            command.PostalCode,
            command.TypeInfo);

        await _unitOfWork.SaveChangeAsync(cancellationToken);

        return Result.Success();
    }
}
