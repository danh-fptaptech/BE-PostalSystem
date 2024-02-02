using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.Users.GetUserByIdAsync;

internal class GetUserByIdAsyncHandler(IUserRepository userRepository) : 
    IRequestHandler<GetUserByIdAsyncQuery, RegisterUserAsyncResponse>
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<RegisterUserAsyncResponse> Handle(
        GetUserByIdAsyncQuery query, 
        CancellationToken cancellationToken)
    {
        User? user = await _userRepository
            .GetUserByIdAsync(query.Id, cancellationToken);

        if (user == null)
        {
            return null;
        }

        return new RegisterUserAsyncResponse(
            user.Fullname, 
            user.Email, 
            user.Phone, 
            user.Avatar);
    }
}
