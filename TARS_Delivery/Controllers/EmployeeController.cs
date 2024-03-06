using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Security;
using TARS_Delivery.Models.DTOs;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services;
using TARS_Delivery.Services.imp;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService service;

        public EmployeeController(IEmployeeService service, IMapper mapper)
        {
            this.service = service;
        }


        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            try
            {
                var employees = await service.GetEmployees();
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
                var employee = await service.GetEmployee(id);
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
        public async Task<ActionResult> CreateEmployee([FromForm] EmployeeDTO employeeDTO, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await service.Create(employeeDTO, file);
                    return Ok("Adding new employee is successful.");
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PermissionName", ex.Message);
                return Problem(ex.Message);
            }
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateEmployee(int id, Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existedEmployee = await service.GetEmployee(id);
                    if (existedEmployee != null)
                    {
                        existedEmployee.Password = employee.Password;
                        return Ok(existedEmployee);
                    }
                    return NotFound("This employee does not exist !");
                }
                return BadRequest();
            }
            catch (Exception)
            {
                throw;
            }
        }


        /*[HttpDelete("{id}")]
        public async Task<ActionResult> RemoveEmployee(int id)
        {
            try
            {
                Employee employee = await service.GetEmployee(id);
                if (employee != null)
                {
                    await service.Remove(id);
                    return Ok("Delete Successfully.");
                }
                return NotFound("This employee does not exist !");
            }
            catch (Exception)
            {
                throw;
            }
        }*/
    }
}
