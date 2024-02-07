using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp
{
    public class EmployeeService : IEmployeeService
    { 
        private readonly IEmployeeRepository repository;
        public EmployeeService (IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<EmployeeDTO>> GetEmployees()
        {
            return await repository.GetEmployees();
        }

        public async Task<EmployeeDTO> GetEmployee(int id)
        {
            return await repository.GetEmployee(id);
        }

        public async Task<EmployeeDTO> Create(EmployeeDTO employeeDTO, IFormFile file)
        {
            return await repository.Create(employeeDTO, file);
        }

        public async Task<EmployeeDTO> Update(int id, EmployeeDTO employeeDTO, IFormFile file)
        {
            return await repository.Update(id, employeeDTO, file);
        }

        //public async Task<Employee> Remove(int id)
        //{
        //    return await repository.Remove(id);
        //}
    }
}
