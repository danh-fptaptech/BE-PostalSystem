using MediatR;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Services.Users.GetUserByIdAsync;
using TARS_Delivery.Services.Users.RegisterUserAsync;

namespace TARS_Delivery.Controllers;

[Route("api/[controller]")]
public class UsersController(ISender sender) 
    : ApiController(sender)
{
    [HttpPost("/login")]
    public async Task<IActionResult> RegisterUser(
        RegisterUserAsyncRequest request,
        CancellationToken cancellationToken)
    {
        RegisterUserAsyncCommand command = new(
            request.FullName, 
            request.Email, 
            request.Password);

        var result = await Sender.Send(
            command, cancellationToken);

        if (result is null)
        {
            return BadRequest();
        }

        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetMemberByIdAsync(
        int id,
        CancellationToken cancellationToken)
    {
        GetUserByIdAsyncQuery query = new(id);

        var result = await Sender.Send(
            query, cancellationToken);

        if (result is null)
        {
            return BadRequest();
        }

        return Ok(result);
    }
}
