using MediatR;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Shared;

namespace TARS_Delivery;

[ApiController]
public abstract class ApiController : ControllerBase
{
    protected readonly ISender Sender;

    protected ApiController(ISender sender)
    {
        Sender = sender;
    }

    protected IActionResult HandleFailure(Result result)
    {
        return result switch
        {
            { IsSuccess: true } => throw new InvalidOperationException(),
            IValidationResult validationResult =>
                BadRequest(
                    CreateProblemDetails(
                        "Validation Error",
                        StatusCodes.Status400BadRequest,
                        result.Error,
                        validationResult.Errors)),
        };
    }

    private static ProblemDetails CreateProblemDetails(
        string title,
        int status,
        Error error,
        Error[]? errors = null)
    {
        return new()
        {
            Title = title,
            Status = status,
            Detail = error.Message,
            Type = error.Code,
            Extensions = { { nameof(errors), errors } }
        };
    }
}
