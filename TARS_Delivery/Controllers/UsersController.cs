using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Services.Users.Command.AddUserAddressAsync;
using TARS_Delivery.Services.Users.Command.ChangeStatusAsync;
using TARS_Delivery.Services.Users.Command.ChangeUserPasswordAsync;
using TARS_Delivery.Services.Users.Command.ForgotPasswordAsync;
using TARS_Delivery.Services.Users.Command.LoginUserAsync;
using TARS_Delivery.Services.Users.Command.RefreshTokenAsync;
using TARS_Delivery.Services.Users.Command.RegisterUserAsync;
using TARS_Delivery.Services.Users.Command.ResetPasswordAsync;
using TARS_Delivery.Services.Users.Command.UpdateUserProfileByIdAsync;
using TARS_Delivery.Services.Users.Command.VerifyUserMailAsync;
using TARS_Delivery.Services.Users.Query.GetAddressListByUserIdAsync;
using TARS_Delivery.Services.Users.Query.GetReceiverAddressListByUserIdAsync;
using TARS_Delivery.Services.Users.Query.GetSenderAddressListByUserIdAsync;
using TARS_Delivery.Services.Users.Query.GetUserByIdAsync;
using TARS_Delivery.Services.Users.Query.GetUserByIdWithPackagesAsync;
using TARS_Delivery.Services.Users.Query.GetUsersAsync;
using TARS_Delivery.Services.Users.Query.GetUsersWithAddressListAsync;
using TARS_Delivery.Services.Users.Query.GetUsersWithAllAsync;
using TARS_Delivery.Services.Users.Query.GetUsersWithPackagesAsync;
using TARS_Delivery.Services.Users.Query.ResetPasswordAsync;

namespace TARS_Delivery.Controllers;

[Route("api/[controller]")]
public class UsersController(ISender sender) 
    : ApiController(sender)
{

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginUserAsyncRequest request,
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

    [Authorize]
    [HttpPut("{id:int}/Change-password")]
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
    [HttpGet("{userId:int}/Addresses")]
    public async Task<IActionResult> GetAddressListByUserIdAsync(
        int userId,
        CancellationToken cancellationToken)
    {
        GetAddressListByUserIdAsyncQuery query = new(userId);

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
    [HttpPost("{userId:int}/Addresses")]
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
            request.PostalCode,
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


    [HttpPost("Forgot-password")]
    public async Task<IActionResult> ForgotPasswordAsync(
        [FromBody] ForgotPasswordAsyncRequest request,
        CancellationToken cancellationToken)
    {
        ForgotPasswordAsyncCommand command = new(request.Email);

        var result = await Sender.Send(
            command, cancellationToken);

        if (result.IsFailure)
        {
            if (result.Error.Code is "ValidationError")
            {
                return HandleFailure(result);
            }

            if (result.Error.Code == "NotFound")
            {
                return NotFound(result.Error);
            }
        }

        return Ok();
    }

    [HttpPut("Reset-password")]
    public async Task<IActionResult> ResetPasswordAsync(
        [FromBody] ResetPasswordAsyncRequest request,
        CancellationToken cancellationToken)
    {
        ResetPasswordAsyncCommand command = new(request.Password, request.Token);

        var result = await Sender.Send(
            command, cancellationToken);

        if (result.IsFailure)
        {
            if (result.Error.Code is "ValidationError")
            {
                return HandleFailure(result);
            }

            if (result.Error.Code == "NotFound")
            {
                return Unauthorized(result.Error);
            }
        }

        return Ok();
    }

    [HttpGet("Reset-password/{token}")]
    public async Task<IActionResult> ResetPasswordAsync(string token,
        CancellationToken cancellationToken)
    {
        ResetPasswordAsyncQuery query = new(token);

        var result = await Sender.Send(
            query, cancellationToken);

        if (result.IsFailure)
        { 
            if (result.Error.Code == "NotFound")
            {
                return Unauthorized(result.Error);
            }
        }

        return Ok(result);
    }

    //[Authorize]
    [HttpGet]
    public async Task<IActionResult> GetUsersAsync(CancellationToken cancellationToken)
    {
        GetUsersAsyncQuery query = new();

        var result = await Sender.Send(query, cancellationToken);

        return Ok(result.Value);
    }

    //[Authorize]
    [HttpGet("Addresses")]
    public async Task<IActionResult> GetUsersWithAddressListAsync(CancellationToken cancellationToken)
    {
        GetUsersWithAddressListAsyncQuery query = new();

        var result = await Sender.Send(query, cancellationToken);

        return Ok(result.Value);
    }

    [Authorize]
    [HttpGet("{id}/Addresses/Sender")]
    public async Task<IActionResult> GetSenderAddressListAsync(int id, CancellationToken cancellationToken)
    {
        GetSenderAddressListByUserIdAsyncQuery query = new(id);

        var result = await Sender.Send(query, cancellationToken);

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
    [HttpGet("{id}/Addresses/Receiver")]
    public async Task<IActionResult> GetReceiverAddressListAsync(int id, CancellationToken cancellationToken)
    {
        GetReceiverAddressListByUserIdAsyncQuery query = new(id);

        var result = await Sender.Send(query, cancellationToken);

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

    //[Authorize]
    [HttpGet("Packages")]
    public async Task<IActionResult> GetUsersWithPackagesAsync(CancellationToken cancellationToken)
    {
        GetUsersWithPackagesAsyncQuery query = new();

        var result = await Sender.Send(query, cancellationToken);

        return Ok(result.Value);
    }

    //[Authorize]
    [HttpGet("All")]
    public async Task<IActionResult> GetUsersWithAllAsync(CancellationToken cancellationToken)
    {
        GetUsersWithAllAsyncQuery query = new();

        var result = await Sender.Send(query, cancellationToken);

        return Ok(result.Value);
    }

    [Authorize]
    [HttpGet("{id}/Packages")]
    public async Task<IActionResult> GetUserByIdWithPackagesAsync(int id, CancellationToken cancellationToken)
    {
        GetUserByIdWithPackagesAsyncQuery query = new(id);

        var result = await Sender.Send(query, cancellationToken);

        return Ok(result.Value);
    }

    /*[Authorize]
    [HttpGet("{id}/All")]
    public async Task<IActionResult> GetUserByIdWithAllAsync(int id, CancellationToken cancellationToken)
    {
        GetUserByIdWithAllAsyncQuery query = new(id);

        var result = await Sender.Send(query, cancellationToken);

        return Ok(result.Value);
    }*/

    [Authorize]
    [HttpPut("{id}")]                                                                 
    public async Task<IActionResult> UpdateUserByIdAsync(
        int id, 
        [FromBody] UpdateUserByIdAsyncRequest request, 
        CancellationToken cancellationToken)
    {
        UpdateUserByIdAsyncCommand command = new(id, request.Fullname, request.Phone);

        var result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            if (result.Error.Code is "ValidationError")
            {
                return HandleFailure(result);
            }

            if (result.Error.Code == "NotFound")
            {
                return NotFound(result.Error);
            }
        }

        return Ok();
    }

    //[Authorize]
    [HttpPut("{id}/Change-status")]
    public async Task<IActionResult> ChangeStatusAsync(
        int id,
        CancellationToken cancellationToken)
    {
        ChangeStatusAsyncCommand command = new(id);

        var result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            if (result.Error.Code == "NotFound")
            {
                return NotFound(result.Error);
            }
        }

        return Ok();
    }
}
