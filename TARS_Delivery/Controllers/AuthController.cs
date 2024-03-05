using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models;
using TARS_Delivery.Models.Enums;
using TARS_Delivery.Providers;
using TARS_Delivery.Services.Users.Command.LoginUserAsync;
using TARS_Delivery.Services.Users.Query.GetUserByIdAsync;

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
    [HttpGet("Profile")]
    public async Task<IActionResult> GetProfileAsync(
    CancellationToken cancellationToken)
    {
        var role = User.FindFirstValue("role");

        var id = User.FindFirstValue(JwtRegisteredClaimNames.Sub);
        if (role != null)
        {
            var employee = await _context.Employees.Include(e => e.Branch).FirstOrDefaultAsync(e => e.Id == int.Parse(id!));
            return Ok(
                new
                {
                    employee.Id,
                    employee.Fullname,
                    employee.Email,
                    employee.EmployeeCode,
                    employee.Address,
                    employee.Province,
                    employee.District,
                    employee.PostalCode,
                    employee.PhoneNumber,
                    employee.Avatar,
                    employee.BranchId,
                    BranchName = employee.Branch.BranchName,
                    Role = new
                    {
                        Name = role,
                        Permissions = User.FindAll("permission").Select(claim => claim.Value)
                    }
                });
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

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginUserAsyncRequest request,
        CancellationToken cancellationToken)
    {
        if (request.Role == "Employee")
        {
            var employee = await _context.Employees
           .Include(e => e.Role)
           .ThenInclude(r => r.RoleHasPermissions)
           .ThenInclude(rhp => rhp.Permission)
           .FirstOrDefaultAsync(e => e.Email == request.UserId);

            if (employee != null)
            {
                bool verify = _hashProvider.Verify(request.Password, employee.Password);

                if (verify)
                {
                    return Ok(new { Token = _jwtProvider.Generate(employee) });
                }
            }


            return Unauthorized("Email or Password is incorrect");
        }
        else
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
}
