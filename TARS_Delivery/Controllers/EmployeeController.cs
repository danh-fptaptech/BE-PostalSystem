using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Services;

namespace TARS_Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
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

        // GET: api/Employees/{employeeCode}
        [HttpGet("code/{code}")] // done
        public async Task<ActionResult> GetEmployeeByCode(string code)
        {
            try
            {
                var employee = await _service.GetEmployeeByCode(code);
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
        public async Task<ActionResult> CreateEmployee([FromBody] RDTOEmployee employee)
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

        // PUT: api/Employees/{employeeCode} => done
        [HttpPut("{code}")]
        public async Task<ActionResult> UpdateEmployee(string code, RDTOUpdateEmployee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var updatedEmployee = await _service.GetEmployeeByCode(code);
                    if(updatedEmployee != null)
                    {
                        return Ok(await _service.UpdateEmployee(code, employee));
                    }
                    return NotFound();
                }
                return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error: ", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // PUT: api/Employees/{employeeCode}/ChangePassword => done
        [HttpPut("{code}/ChangePassword")]
        public async Task<ActionResult> UpdatePassword(string code, RDTOChangePassword employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var updatedEmployee = await _service.GetEmployeeByCode(code);
                    if (updatedEmployee != null)
                    {
                        await _service.UpdatePassword(code, employee);
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
        public async Task<ActionResult> ChangeStatus(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existedEmployee = await _service.GetEmployee(id);
                    if(existedEmployee != null)
                    {
                        return Ok(await  _service.ChangeStatus(id));
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

        // PUT: api/Employees/{employeeCode}/UpdateInfoAsync => done
        [HttpPut("{code}/UpdateInfoAsync")]
        public async Task<ActionResult> UpdateInfoAsync(string code, [FromBody] UpdateInfoAsync employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var updatedEmployee = await _service.GetEmployeeByCode(code);
                    if (updatedEmployee != null)
                    {
                        await _service.UpdateInfoAsync(code, employee);
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

        [HttpDelete("{id}/RejectUpdateInfo")]
        public async Task<ActionResult> RejectUpdateInfo(int id)
        {
            try
            {
                var employee = await _service.GetEmployee(id);
                if (employee != null)
                {
                    if (employee.SubmitedInfo != null)
                    {
                        var updatedEmployee = await _service.RejectUpdateInfo(id);
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

        [HttpGet("SubmitedInfo")]
        public async Task<ActionResult> GetSubmitedInfoEmployees()
        {
            try
            {
                var employees = await _service.GetSubmitedInfoEmployees();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("Branch")]
        public async Task<ActionResult> GetEmployeesByBranch(string branchName)
        {
            try
            {
                var employees = await _service.GetEmployeesByBranch(branchName);
                return Ok(employees);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}