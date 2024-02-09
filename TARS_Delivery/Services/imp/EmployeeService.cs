using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enum;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp
{
    public class EmployeeService : IEmployeeService
    { 
        private readonly IEmployeeRepository _repository;
        public EmployeeService (IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<SDTOEmployee>> GetEmployees()
        {
            return await _repository.GetEmployees();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _repository.GetEmployee(id);
        }

        public async Task<Employee> Create(RDTOEmployee employee)
        {
            Employee newEmployee = new()
            {
                EmployeeCode = employee.EmployeeCode,
                Email = employee.Email,
                Password = employee.Password,
                Fullname = employee.Fullname,
                Address = employee.Address,
                Province = employee.Province,
                District = employee.District,
                PhoneNumber = employee.PhoneNumber,
                SubmitedInfo = null,
                Avatar = employee.Avatar,
                BranchId = employee.BranchId,
                RoleId = employee.RoleId,
                Status = EStatusData.Active,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            return await _repository.Create(newEmployee);
        }

        public async Task<Employee> UpdatePassword(int id, UpdatePassword employee)
        {
            var updatedEmployee = await _repository.GetEmployee(id);
            if (updatedEmployee == null)
            {
                throw new Exception("Employee not found !");
            }
            else
            {
                return await _repository.UpdatePassword(id, employee);
            }
        }

        public Task<Employee> UpdateInfo(int id, EmployeeUpdateInfo employee)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> CheckLogin(RDTOEmployeeLogin employee)
        {
            return await _repository.CheckLogin(employee);
        }
    }
}
