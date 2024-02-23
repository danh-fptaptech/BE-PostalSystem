using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services.imp
{
    public class EmployeeTokenService
    {
        public static string GenerateToken(IConfiguration configuration, Employee employee)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>();

            claims.Add(new Claim("Id", employee.Id.ToString()));
            claims.Add(new Claim("Role", employee.RoleId.ToString()));

            var token = new JwtSecurityToken(
                configuration["Jwt:Key"],
                configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
