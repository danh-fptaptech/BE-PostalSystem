
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DatabaseContext _context;
        private readonly IMapper mapper;
        public EmployeeRepository(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }


        public async Task<IEnumerable<SDTOEmployee>> GetEmployees()
        {
            IEnumerable<Employee> employees = await _context.Employees.ToListAsync();
            return mapper.Map<IEnumerable<SDTOEmployee>>(employees);
        }    

        public async Task<Employee> GetEmployee(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task<Employee> Create(Employee employee)
        {
            try
            {
                var duplicatedCode = await _context.Employees.FirstOrDefaultAsync(e => e.EmployeeCode == employee.EmployeeCode);
                var existedEmail = await _context.Employees.FirstOrDefaultAsync(e => e.Email == employee.Email);
                var existedPhone = await _context.Employees.FirstOrDefaultAsync(e => e.PhoneNumber == employee.PhoneNumber);
                
                if (duplicatedCode != null)
                {
                    throw new Exception("The employee code has already existed.");
                }

                if(existedEmail != null)
                {
                    throw new Exception("The email address has already been used.");
                }

                if(existedPhone != null)
                {
                    throw new Exception("The phone number has already been used.");
                }

                await _context.Employees.AddAsync(employee);
                await _context.SaveChangesAsync();
                return employee;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Employee> UpdatePassword(int id, UpdatePassword employee)
        {
            try
            {
                Employee updatedEmployee = await _context.Employees.FindAsync(id);
                if(updatedEmployee != null)
                {
                    if (!string.IsNullOrEmpty(updatedEmployee.Password))
                    {
                        updatedEmployee.Password = employee.Password;
                    }

                    updatedEmployee.UpdatedAt = DateTime.Now;

                    await _context.SaveChangesAsync();
                    return updatedEmployee;
                }

                throw new Exception("Employee not found !");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static string GenerateSubmittedInfo(RDTOEmployee employee)
        {
            string submitedInfo = 
                $"Address: {employee.Address}, " +
                $"Province: {employee.Province}, " +
                $"District: {employee.District}, " +
                $"PhoneNumber: {employee.PhoneNumber}, " +
                $"BranchId: {employee.BranchId}, ";

            return submitedInfo;
        }

        public Task<Employee> UpdateInfo(int id, EmployeeUpdateInfo employee)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Employee> CheckLogin(RDTOEmployeeLogin employee)
        {
            try
            {
                var existedEmployee = await _context.Employees.FirstOrDefaultAsync(e => e.Email == employee.Email);

                if (existedEmployee != null)
                {
                    var checkPassword = AccountSecurity.VerifyPassword(employee.Password, existedEmployee.Password);
                    if (checkPassword)
                    {
                        return existedEmployee;
                    }
                    return null;
                }
                throw new Exception("The employee does not exist !");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
