using MediatR;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.Query.ResetPasswordAsync;

internal class ResetPasswordAsyncHandler(IUserRepository userRepository)
    : IRequestHandler<ResetPasswordAsyncQuery, Result>
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<Result> Handle(
    ResetPasswordAsyncQuery query, 
        CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetUserByPasswordResetTokenAsync(query.Token, cancellationToken);

        if (user == null)
        {
            return Result.Failure(ResetPasswordAsyncErrors.NotFound);
        }

        return Result.Success();
    }
}
