
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp
{
    public class EmployeeRepository(DatabaseContext context, IMapper mapper) : IEmployeeRepository
    {
        private readonly DatabaseContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<IEnumerable<SDTOEmployee>> GetEmployees()
        {
            IEnumerable<Employee> employees = await _context.Employees.ToListAsync();
            return _mapper.Map<IEnumerable<SDTOEmployee>>(employees);
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
                        var hashedPassword = PasswordHasher.HashPassword(employee.Password);
                        updatedEmployee.Password = hashedPassword;
                    }

                    updatedEmployee.UpdatedAt = DateTime.Now;

                    await _context.SaveChangesAsync();
                    return updatedEmployee;
                }

                throw new Exception("The employee does not exist !");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Employee> UpdateInfoAsync(int id, EmployeeUpdateInfo employee)
        {
            try
            {
                Employee updatedEmployee = await _context.Employees.FindAsync(id);
                if (updatedEmployee != null)
                {
                    updatedEmployee.SubmitedInfo = GenerateSubmitedInfo(employee);

                    await _context.SaveChangesAsync();
                    return updatedEmployee;
                }
                throw new Exception("The employee does not exist !");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static string? GenerateSubmitedInfo(EmployeeUpdateInfo employee)
        {
            string submitedInfo =
                $"Email: {employee.Email}, " +
                $"Address: {employee.Address}, " +
                $"Province: {employee.Province}, " +
                $"District: {employee.District}, " +
                $"PhoneNumber: {employee.PhoneNumber}, " +
                $"Avatar: {employee.Avatar}, ";

            return submitedInfo;
        }


        public async Task<Employee> CheckLogin(RDTOEmployeeLogin employee)
        {
            try
            {
                var existedEmployee = await _context.Employees.FirstOrDefaultAsync(e => e.Email == employee.Email);

                if (existedEmployee != null)
                {
                    var checkPassword = await _context.Employees.FirstOrDefaultAsync(e => e.Password == employee.Password);
                    if (checkPassword != null)
                    {
                        return existedEmployee;
                    }
                    return null;
                }
                throw new Exception("The employee does not exist!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
