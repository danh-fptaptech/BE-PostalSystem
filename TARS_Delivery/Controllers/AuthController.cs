using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;
using TARS_Delivery.Providers;
using TARS_Delivery.Services;
using TARS_Delivery.Services.Users.GetUserByIdAsync;
using TARS_Delivery.Services.Users.LoginUserAsync;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthController(
    ISender sender, 
    IJwtProvider jwtProvider, 
    IHashProvider hashProvider,
    DatabaseContext context)
    : ApiController(sender)
{
    private readonly IJwtProvider _jwtProvider = jwtProvider;
    private readonly IHashProvider _hashProvider = hashProvider;
    private readonly DatabaseContext _context = context;

    [Authorize]
    [HttpGet("profile")]
    public async Task<IActionResult> GetProfileAsync(
    CancellationToken cancellationToken)
    {
        var role = User.FindFirstValue("Role");
        var id = User.FindFirstValue(JwtRegisteredClaimNames.Sub);
        if (role != null)
        {
            // return employee profile
            return Ok();
        }

        GetUserByIdAsyncQuery query = new(int.Parse(id!));

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

        if (result.Value.Status == EStatusData.Inactive)
        {
            return Ok();
        }

        return Ok(result.Value);
    }

    [HttpPost("Employee/Login")]
    public async Task<IActionResult> Login([FromBody] EmployeeCredentials credentials)
    {
        var employee = await _context.Employees
            .Include(e => e.Role)
            .ThenInclude(r => r.RoleHasPermissions)
            .ThenInclude(rhp => rhp.Permission)
            .FirstOrDefaultAsync(e => e.Email == credentials.Email);

        if (employee != null)
        {
            bool verify = _hashProvider.Verify(credentials.Password, employee.Password);
            
            if (verify)
            {
                return Ok(new { Token = _jwtProvider.Generate(employee) });
            }
        }


        return Unauthorized("Email or Password is incorrect");
    }

    [HttpPost("User/Login")]
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
}
