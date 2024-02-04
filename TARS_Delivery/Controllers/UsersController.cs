using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Services.Users.AddUserAddressAsync;
using TARS_Delivery.Services.Users.ChangeUserPasswordAsync;
using TARS_Delivery.Services.Users.GetUserByIdAsync;
using TARS_Delivery.Services.Users.GetUserByIdWithAddressListAsync;
using TARS_Delivery.Services.Users.LoginUserAsync;
using TARS_Delivery.Services.Users.RegisterUserAsync;
using TARS_Delivery.Services.Users.RefreshTokenAsync;

namespace TARS_Delivery.Controllers;

[Route("api/[controller]")]
public class UsersController(ISender sender) 
    : ApiController(sender)
{
    [HttpPost("Register")]
    public async Task<IActionResult> RegisterUserAsync(
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
    public async Task<IActionResult> LoginUserAsync(
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
    [HttpPut("Change-password/{id:int}")]
    public async Task<IActionResult> ChangeUserPasswordAsync(
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

    [HttpPost("Refresh-token")]
    public async Task<IActionResult> RefreshToken(
        CancellationToken cancellationToken)
    {
        RefreshTokenAsyncCommand command = new();

        string? result = await Sender.Send(
            command, cancellationToken);
        
        if (result is null)
        {
            return Unauthorized();
        }

        return Ok(result);
    }

    [Authorize]
    [HttpDelete("Revoke-token")]
    public async Task<IActionResult> RevokeToken(
        CancellationToken cancellationToken)
    {
        RefreshTokenAsyncCommand command = new();

        string? result = await Sender.Send(
            command, cancellationToken);
        //
        if (result is null)
        {
            return Unauthorized();
        }

        return Ok(result);
    }

    [Authorize]
    [HttpGet("Addresses/{userId:int}")]
    public async Task<IActionResult> GetUserAddressListAsync(
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
    [HttpPost("Addresses/{userId:int}")]
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
