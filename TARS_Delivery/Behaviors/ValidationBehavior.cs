using FluentValidation;
using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Behaviors;

public class ValidationBehavior<TRequest, TReponse>(
    IEnumerable<IValidator<TRequest>> validators)
        : IPipelineBehavior<TRequest, TReponse>
        where TRequest : IRequest<TReponse>
        where TReponse : Result
{
    private readonly IEnumerable<IValidator<TRequest>> _validators = validators;

    public async Task<TReponse> Handle(
        TRequest request, 
        RequestHandlerDelegate<TReponse> next, 
        CancellationToken cancellationToken)
    {
        if (!_validators.Any())
        {
            return await next();
        }

        Error[] errors = _validators
            .Select(validator => validator.Validate(request))
            .SelectMany(validatorResult => validatorResult.Errors)
            .Where(validatorFailure => validatorFailure != null)
            .Select(failure => new Error(failure.PropertyName, failure.ErrorMessage))
            .Distinct()
            .ToArray();

        if (errors.Length != 0)
        {
            return CreateValidationResult<TReponse>(errors);
        }

        return await next();
    }

    private static TResult CreateValidationResult<TResult>(Error[] errors)
        where TResult : Result
    {
        if (typeof(TResult) == typeof(Result))
        {
            return (ValidationResult.WithErrors(errors) as TResult)!;
        }

        object validationResult = typeof(ValidationResult<>)
               .GetGenericTypeDefinition()
               .MakeGenericType(typeof(TResult).GenericTypeArguments[0])
               .GetMethod(nameof(ValidationResult.WithErrors))!
               .Invoke(null, [errors])!;

        return (TResult)validationResult;
    }
}
