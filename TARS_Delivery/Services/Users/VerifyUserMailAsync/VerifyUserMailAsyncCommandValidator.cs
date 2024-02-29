using FluentValidation;

namespace TARS_Delivery.Services.Users.VerifyUserMailAsync;

internal class VerifyUserMailAsyncCommandValidator : AbstractValidator<VerifyUserMailAsyncCommand>
{
    public VerifyUserMailAsyncCommandValidator()
    {
        RuleFor(x => x.Otp)
            .NotEmpty()
            .Length(6);
    }
}
