
using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Services.imp;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _service;

        public EmployeeController(EmployeeService service)
        {
            _service = service;
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
            catch (Exception e)
            {

                ModelState.AddModelError("EmployeeCode", e.Message);
                ModelState.AddModelError("Email", e.Message);
                ModelState.AddModelError("PhoneNumber", e.Message);
                return Problem(e.Message);
            }
        }


        [HttpPut("{id}")]
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
            catch (Exception)
            {
                throw;
            }
        }


        [HttpPatch("{id}")]
        public async Task<ActionResult> UpdateInfo(int id, [FromForm] EmployeeUpdateInfo employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var updatedEmployee = await _service.GetEmployee(id);
                    if (updatedEmployee != null)
                    {
                        await _service.UpdateInfo(id, employee);
                        return Ok(updatedEmployee);
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
    }
}
