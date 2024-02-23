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
using TARS_Delivery.Services.Users.VerifyUserMailAsync;
using System.Security.Claims;
using TARS_Delivery.Shared;

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

        if (result.IsFailure)
        {
            if (result.Error.Code is "ValidationError")
            {
                return HandleFailure(result);
            }

            if (result.Error.Code == "UniqueUser")
            {
                return Conflict(result.Error);
            }
        }

        return Ok();
    }

    [HttpPost("Verify-email")]
    public async Task<IActionResult> VerifyUserEmailAsync(
        [FromBody] VerifyUserMailAsyncRequest request,
        CancellationToken cancellationToken)
    {
        VerifyUserMailAsyncCommand command = new(request.Otp);

        var result = await Sender.Send(
            command, cancellationToken);

        if (result.IsFailure)
        {
            if (result.Error.Code is "ValidationError")
            {
                return HandleFailure(result);
            }

            if (result.Error.Code == "IncorectOtp")
            {
                return Unauthorized(result.Error);
            }
        }

        return Ok(result.Value);
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

        if (result.IsFailure)
        {
            if (result.Error.Code is "ValidationError")
            {
                return HandleFailure(result);
            }

            if (result.Error.Code is "Unauthorized" or "IncorrectPassword")
            {
                return Unauthorized(result.Error);
            }
            
            if (result.Error.Code == "NotFound")
            {
                return NotFound(result.Error);
            }
        }

        return Ok(result.Value);
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

        if (result.IsFailure)
        {
            if (result.Error.Code is "ValidationError")
            {
                return HandleFailure(result);
            }

            if (result.Error.Code is "Unauthorized" or "IncorrectPassword")
            {
                return Unauthorized(result.Error);
            }

            if (result.Error.Code == "NotFound")
            {
                return NotFound(result.Error);
            }
        }

        return Ok();
    }

    [HttpPost("Refresh-token")]
    public async Task<IActionResult> RefreshToken(
        CancellationToken cancellationToken)
    {
        RefreshTokenAsyncCommand command = new();

        var result = await Sender.Send(
            command, cancellationToken);

        if (result.IsFailure)
        {
            if (result.Error.Code == "Unauthorized")
            {
                return Unauthorized(result.Error.Message);
            }
        }

        return Ok(result.Value);
    }

    [Authorize]
    [HttpDelete("Revoke-token")]
    public async Task<IActionResult> RevokeToken(
        CancellationToken cancellationToken)
    {
        RefreshTokenAsyncCommand command = new();

        var result = await Sender.Send(
            command, cancellationToken);

        if (result.IsFailure)
        {
            if (result.Error.Code == "Unauthorized")
            {
                return Unauthorized(result.Error.Message);
            }
        }

        return Ok();
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

        if (result.IsFailure)
        {
            if (result.Error.Code == "Unauthorized")
            {
                return Unauthorized(result.Error.Message);
            }

            if (result.Error.Code == "NotFound")
            {
                return NotFound(result.Error.Message);
            }
        }

        return Ok(result.Value);
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

        if (result.IsFailure)
        {
            if (result.Error.Code == "Unauthorized")
            {
                return Unauthorized(result.Error.Message);
            }

            if (result.Error.Code == "NotFound")
            {
                return NotFound(result.Error.Message);
            }
        }

        return Ok(result.Value);
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

        if (result.IsFailure)
        {
            if (result.Error.Code is "ValidationError")
            {
                return HandleFailure(result);
            }

            if (result.Error.Code == "Unauthorized")
            {
                return Unauthorized(result.Error.Message);
            }

            if (result.Error.Code == "NotFound")
            {
                return NotFound(result.Error.Message);
            }
        }

        return Created();
    }
}
