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

            if (!string.IsNullOrEmpty(employee.Email))
            {
                claims.Add(new Claim("Email", employee.Email));
            }

            if (!string.IsNullOrEmpty(employee.EmployeeCode))
            {
                claims.Add(new Claim("EmployeeCode", employee.EmployeeCode));
            }

            if (employee.Role != null && !string.IsNullOrEmpty(employee.Role.RoleName))
            {
                claims.Add(new Claim("Role", employee.Role.RoleName));
                claims.Add(new Claim(ClaimTypes.Role, employee.Role.RoleName));
            }

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
