using FluentValidation;

namespace TARS_Delivery.Services.Users.Command.ForgotPasswordAsync;

internal class ForgotPassswordAsyncCommandValidator : AbstractValidator<ForgotPasswordAsyncCommand>
{
    public ForgotPassswordAsyncCommandValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();
    }
}
