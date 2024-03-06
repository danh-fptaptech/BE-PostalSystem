using FluentValidation;

namespace TARS_Delivery.Services.Users.Command.ResetPasswordAsync;

internal class ForgotPassswordAsyncCommandValidator : AbstractValidator<ResetPasswordAsyncCommand>
{
    public ForgotPassswordAsyncCommandValidator()
    {
        RuleFor(x => x.Token)
            .NotEmpty();

        RuleFor(x => x.Password)
            .NotEmpty();
    }
}
