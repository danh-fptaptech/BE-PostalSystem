using FluentValidation;

namespace TARS_Delivery.Services.Users.Command.LoginUserAsync;

internal class RegisterUserAsyncCommandValidator : AbstractValidator<LoginUserAsyncCommand>
{
    public RegisterUserAsyncCommandValidator()
    {
        RuleFor(x => x.UserId)
            .NotEmpty();

        RuleFor(x => x.Password)
            .NotEmpty();
    }
}
