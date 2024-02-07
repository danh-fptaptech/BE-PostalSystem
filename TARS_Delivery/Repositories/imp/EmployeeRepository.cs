
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using TARS_Delivery.Helpers;
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
                await _context.Employees.AddAsync(employee);
                await _context.SaveChangesAsync();
                return employee;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
                //throw new Exception("Error when trying to create new employee.");
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
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
            throw new NotImplementedException();
        }
    }
}
