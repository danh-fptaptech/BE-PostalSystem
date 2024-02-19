
using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Services.imp;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        // GET: api/Employees => done
        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            try
            {
                var employees = await _service.GetEmployees();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // GET: api/Employees/{employeeId}
        [HttpGet("{id}")] // done
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
            catch (Exception ex)
            {
                ModelState.AddModelError("Error: ", ex.Message);
                throw new Exception(ex.Message);
            }
        }

        // POST: api/Employees/employee => done
        [HttpPost]
        public async Task<ActionResult> CreateEmployee([FromForm] RDTOEmployee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var createdEmployee = await _service.CreateEmployeeAsync(employee);
                    return Ok(createdEmployee);
                }

                return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error: ", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // PUT: api/Employees/{employeeId}/ChangePassword => done
        [HttpPut("{id}/ChangePassword")]
        public async Task<ActionResult> UpdatePassword(int id, [FromForm] RDTOChangePassword employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var updatedEmployee = await _service.GetEmployee(id);
                    if (updatedEmployee != null)
                    {
                        await _service.UpdatePassword(id, employee);
                        return Ok("Change password successfully.");
                    }
                    return NotFound("This employee does not exist !");
                }
                return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error: ", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // PUT: api/Employees/{employeeId}/ChangeStatus => done
        [HttpPut("{id}/ChangeStatus")]
        public async Task<ActionResult> ChangeStatus(int id, [FromForm] RDTOChangeStatus employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existedEmployee = await _service.GetEmployee(id);
                    if(existedEmployee != null)
                    {
                        return Ok(await  _service.ChangeStatus(id, employee));
                    }
                    return BadRequest(ModelState);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error: ", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // PUT: api/Employees/{employeeId}/UpdateInfoAsync => done
        [HttpPut("{id}/UpdateInfoAsync")]
        public async Task<ActionResult> UpdateInfoAsync(int id, [FromForm] UpdateInfoAsync employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var updatedEmployee = await _service.GetEmployee(id);
                    if (updatedEmployee != null)
                    {
                        await _service.UpdateInfoAsync(id, employee);
                        return Ok("Send updated request successfully. Please wait for the admin accept.");
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

        // PUT: api/Employees/{employeeId}/AcceptUpdateInfo => done
        [HttpPut("{id}/AcceptUpdateInfo")]
        public async Task<ActionResult> AcceptSumitedInfo(int id)
        {
            try
            {   var employee = await _service.GetEmployee(id);
                if (employee != null)
                {
                    if(employee.SubmitedInfo != null)
                    {
                        var updatedEmployee = await _service.AcceptUpdateInfo(id);
                        return Ok(updatedEmployee);
                    }
                    return Content("Don't have updated request.");
                }
                return NotFound("The employee doesn't exist !");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
 
    }
}