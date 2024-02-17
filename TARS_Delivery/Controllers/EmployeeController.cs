
using Microsoft.AspNetCore.Authorization;
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

        public EmployeeController(EmployeeService service)
        {
            _service = service;
        }


        [HttpGet] // done
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult> GetEmployees(int id)
        {
            try
            {
                var adminCredential = await _service.GetEmployee(id);
                if(adminCredential != null && adminCredential.RoleName == "Admin")
                {
                    var employees = await _service.GetEmployees();
                    return Ok(employees);
                }
                return Content("The employee doesn't have right to access.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


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
            catch (Exception)
            {
                throw;
            }
        }


        [HttpPost] // done
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


        [HttpPut("{id}/ChangePassword")] // done
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


        [HttpPut("{id}/ChangeStatus")] // still fix
        public async Task<ActionResult> ChangeStatus(int id, [FromForm] RDTOChangeStatus employee)
        {
            try
            {
                var adminCredential = await _service.GetEmployee(id);
                if (adminCredential != null && adminCredential.Role.RoleName.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    if (ModelState.IsValid)
                    {
                        var updatedEmployee = await _service.GetEmployee(id);
                        if (updatedEmployee != null)
                        {
                            await _service.ChangeStatus(id, employee);
                            return Ok(updatedEmployee);
                        }
                        return NotFound("This employee does not exist !");
                    }
                    return BadRequest();
                }
                return Problem("It is possible for the admin to change status.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        [HttpPut("{id}/UpdateInfoAsync")] // done
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


        [HttpPut("{id}/AcceptUpdateInfo")] // done
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult> AcceptSumitedInfo(int id)
        {
            try
            {
                var employee = await _service.GetEmployee(id);
                if (employee != null)
                {
                    var updatedEmployee = await _service.AcceptUpdateInfo(id);
                    return Ok(updatedEmployee);
                }
                return NotFound("The employee does not exist !");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}