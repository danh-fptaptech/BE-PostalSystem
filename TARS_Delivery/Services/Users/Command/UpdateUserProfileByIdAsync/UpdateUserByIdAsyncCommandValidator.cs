using FluentValidation;

namespace TARS_Delivery.Services.Users.Command.UpdateUserProfileByIdAsync;

internal class UpdateUserByIdAsyncCommandValidator : AbstractValidator<UpdateUserByIdAsyncCommand>
{
    public UpdateUserByIdAsyncCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty();

        RuleFor(x => x.Fullname)
            .NotEmpty();

        RuleFor(x => x.Phone)
            .NotEmpty();
    }
}
