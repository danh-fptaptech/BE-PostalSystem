using FluentValidation;

namespace TARS_Delivery.Services.Users.Command.RegisterUserAsync;

internal class VerifyUserMailAsyncCommandValidator : AbstractValidator<RegisterUserAsyncCommand>
{
    public VerifyUserMailAsyncCommandValidator()
    {
        RuleFor(x => x.FullName)
            .NotEmpty();

        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();

        RuleFor(x => x.Phone)
            .NotEmpty();

        RuleFor(x => x.Password)
            .NotEmpty();
    }
}
