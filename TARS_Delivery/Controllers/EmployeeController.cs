
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
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _service;
        private readonly DatabaseContext _context;

        public EmployeeController(EmployeeService service, DatabaseContext context)
        {
            _service = service;
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            try
            {
                var employees = await _service.GetEmployees();
                return Ok(employees);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> GetEmployee(int id)
        {
            try
            {
                var employee = await _service.GetEmployee(id);
                if (employee != null)
                {
                    return Ok(employee);
                }
                return NotFound("This employee does not exist !");
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpPost]
        public async Task<ActionResult> CreateEmployee([FromForm] RDTOEmployee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _service.Create(employee);
                    return Ok(employee);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("EmployeeCode", ex.Message);
                ModelState.AddModelError("Email", ex.Message);
                ModelState.AddModelError("PhoneNumber", ex.Message);
                return Problem(ex.Message);
            }
        }

        
        [HttpPut("{id}/ChangePassword")]
        public async Task<ActionResult> UpdatePassword(int id, [FromForm] UpdatePassword employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var updatedEmployee = await _service.GetEmployee(id);
                    if (updatedEmployee != null)
                    {
                        await _service.UpdatePassword(id, employee);
                        return Ok(updatedEmployee);
                    }
                    return NotFound("This employee does not exist !");
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        [HttpPut("{id}/UpdateInfo")]
        public async Task<ActionResult> UpdateInfoAsync(int id, [FromForm] EmployeeUpdateInfo employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var updatedEmployee = await _service.GetEmployee(id);
                    if (updatedEmployee != null)
                    {
                        await _service.UpdateInfoAsync(id, employee);
                        return Ok(updatedEmployee);
                    }
                    return NotFound("This employee does not exist !");
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Check Login
        [HttpPost("login")]
        public async Task<ActionResult<Employee>> CheckLogin([FromForm] RDTOEmployeeLogin employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _service.CheckLogin(employee);
                    return Ok(employee);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
