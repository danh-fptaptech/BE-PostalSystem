using MediatR;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.GetUsersAsync;

internal class GetUsersAsyncHandler(IUserRepository userRepository) 
    : IRequestHandler<GetUsersAsyncQuery, Result<IReadOnlyCollection<UserResponse>>>
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<Result<IReadOnlyCollection<UserResponse>>> Handle(
        GetUsersAsyncQuery query, 
        CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetUsersAsync(cancellationToken);

        IReadOnlyCollection<UserResponse> result = users
            .Select(user => new UserResponse(
                user.Id, user.Fullname, user.Email, user.Phone, user.Avatar, user.Status))
            .ToList();

        return Result.Success(result);
    }
}
