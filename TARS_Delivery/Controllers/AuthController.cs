using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TARS_Delivery.Models.Enums;
using TARS_Delivery.Services.Users.GetUserByIdAsync;

namespace TARS_Delivery.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthController(ISender sender)
    : ApiController(sender)
{
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
}
