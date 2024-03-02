using FluentValidation;

namespace TARS_Delivery.Services.Users.Command.ChangeUserPasswordAsync;

internal class AddUserAddressAsyncValidator : AbstractValidator<ChangeUserPasswordAsyncCommand>
{
    public AddUserAddressAsyncValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty();

        RuleFor(x => x.OldPassword)
            .NotEmpty().NotEqual(x => x.NewPassword).WithMessage("New password must be different from old password");

        RuleFor(x => x.NewPassword)
            .NotEmpty();
    }
}
