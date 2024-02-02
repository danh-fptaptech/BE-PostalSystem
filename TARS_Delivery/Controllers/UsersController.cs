using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Services.Users.AddUserAddressAsync;
using TARS_Delivery.Services.Users.ChangeUserPasswordAsync;
using TARS_Delivery.Services.Users.GetUserByIdWithAddressListAsync;
using TARS_Delivery.Services.Users.GetUserByIdAsync;
using TARS_Delivery.Services.Users.LoginUserAsync;
using TARS_Delivery.Services.Users.RegisterUserAsync;

namespace TARS_Delivery.Controllers;

[Route("api/[controller]")]
public class UsersController(ISender sender) 
    : ApiController(sender)
{
    [HttpPost("Register")]
    public async Task<IActionResult> RegisterUser(
        [FromBody] RegisterUserAsyncRequest request,
        CancellationToken cancellationToken)
    {
        RegisterUserAsyncCommand command = new(
            request.FullName, 
            request.Email, 
            request.Phone,
            request.Password);

        var result = await Sender.Send(
            command, cancellationToken);

        if (result is null)
        {
            return BadRequest();
        }

        return Ok(result);
    }

    [HttpPost("Login")]
    public async Task<IActionResult> LoginUser(
        [FromBody] LoginUserAsyncRequest request,
        CancellationToken cancellationToken)
    {
        LoginUserAsyncCommand command = new(
            request.UserId,
            request.Password);

        var result = await Sender.Send(
            command, cancellationToken);

        if (result is null)
        {
            return BadRequest();
        }

        return Ok(result);
    }

    [Authorize]
    [HttpPut("change-password/{id:int}")]
    public async Task<IActionResult> ChangeUserPassword(
        int id,
        [FromBody] ChangeUserPasswordAsyncRequest request,
        CancellationToken cancellationToken)
    {
        ChangeUserPasswordAsyncCommand command = new(
            id,
            request.OldPassword,
            request.NewPassword);

        var result = await Sender.Send(
            command, cancellationToken);

        if (!result)
        {
            return BadRequest();
        }

        return Ok(result);
    }

    [Authorize]
    [HttpGet("addresses/{userId:int}")]
    public async Task<IActionResult> GetUserAddressList(
        int userId,
        CancellationToken cancellationToken)
    {
        GetUserAddressListByIdAsyncQuery query = new(userId);

        var result = await Sender.Send(
            query, cancellationToken);

        return Ok(result);
    }

    [Authorize]
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetUserByIdAsync(
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

    [Authorize]
    [HttpPost("addresses/{userId:int}")]
    public async Task<IActionResult> AddUserAddressAsync(
    int userId,
    [FromBody] AddUserAddressAsyncRequest request,
    CancellationToken cancellationToken)
    {
        AddUserAddressAsyncCommand command = new(
            userId,
            request.Name,
            request.PhoneNumber,
            request.Address,
            request.City,
            request.District,
            request.Ward,
            request.TypeInfo);

        var result = await Sender.Send(
            command, cancellationToken);

        if (!result)
        {
            return BadRequest();
        }

        return Ok(result);
    }
}
