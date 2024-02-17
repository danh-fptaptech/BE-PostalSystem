using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services.imp;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly DatabaseContext _context;
        public AuthController(IConfiguration configuration, DatabaseContext context)
        {
            _configuration = configuration;
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> Login([FromForm] EmployeeCredentials credentials)
        {
            var employee = await Authenticate(credentials);
            if (employee != null)
            {
                var tokenString = EmployeeTokenService.GenerateToken(_configuration, employee);
                if(!string.IsNullOrEmpty( tokenString) )
                {
                    return Ok(new { Token = tokenString });
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Failed to generate token.");
                }
                
            }
            else
            {
                return NotFound("The employee does not exist !");
            }
        }

        private async Task<Employee> Authenticate(EmployeeCredentials employeeCredentials)
        {
            var currentEmployee = await _context.Employees
                .FirstOrDefaultAsync( e => e.Email.ToLower() == employeeCredentials.Email && e.Password == employeeCredentials.Password);
            if (currentEmployee != null)
            {
                return currentEmployee;
            }
            return new Employee(); 
        }
    }
}
