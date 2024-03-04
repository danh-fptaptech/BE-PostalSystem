using FluentValidation;

namespace TARS_Delivery.Services.Users.Command.AddUserAddressAsync;

internal class AddUserAddressAsyncValidator : AbstractValidator<AddUserAddressAsyncCommand>
{
    public AddUserAddressAsyncValidator()
    {
        RuleFor(x => x.UserId)
            .NotEmpty();

        RuleFor(x => x.Name)
            .NotEmpty();

        RuleFor(x => x.PhoneNumber)
            .NotEmpty();

        RuleFor(x => x.Address)
            .NotEmpty();

        RuleFor(x => x.City)
            .NotEmpty();

        RuleFor(x => x.District)
            .NotEmpty();

        RuleFor(x => x.Ward)
            .NotEmpty();

        RuleFor(x => x.TypeInfo)
            .NotNull();
    }
}
