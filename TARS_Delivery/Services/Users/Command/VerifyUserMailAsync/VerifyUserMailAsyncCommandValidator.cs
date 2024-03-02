using FluentValidation;

namespace TARS_Delivery.Services.Users.Command.VerifyUserMailAsync;

internal class VerifyUserMailAsyncCommandValidator : AbstractValidator<VerifyUserMailAsyncCommand>
{
    public VerifyUserMailAsyncCommandValidator()
    {
        RuleFor(x => x.Otp)
            .NotEmpty()
            .Length(6);
    }
}
