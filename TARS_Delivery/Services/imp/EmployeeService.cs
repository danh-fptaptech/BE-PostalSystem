using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models;
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

        public async Task<SDTOEmployee> GetEmployee(int id)
        {
            return await _repository.GetEmployee(id);
        }

        public async Task<Employee> CreateEmployeeAsync(RDTOEmployee employee)
        {
            Employee newEmployee = new()
            {
                EmployeeCode = employee.EmployeeCode,
                Email = employee.Email,
                Password = PasswordHasher.HashPassword(employee.Password),
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
            return await _repository.CreateEmployeeAsync(newEmployee);
        }

        public async Task<Employee> UpdatePassword(int id, RDTOChangePassword employee)
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

        public async Task<Employee> UpdateInfoAsync(int id, UpdateInfoAsync employee)
        {
            return await _repository.UpdateInfoAsync(id, employee);
        }

        public Task<Employee> AcceptUpdateInfo(int id)
        {
            return _repository.AcceptUpdateInfo(id);
        }

        public async Task<Employee> ChangeStatus(int id, RDTOChangeStatus employee)
        {
            var updateedEmployee = await _repository.GetEmployee(id);
            if (updateedEmployee == null)
            {
                throw new Exception("The employee does not exist !");
            }
            return await _repository.ChangeStatus(id, employee);
        }

        public async Task<IEnumerable<SDTOEmployee>> GetSubmitedInfoEmployees()
        {
            return await _repository.GetSubmitedInfoEmployees();
        }

        public async Task<Employee> UpdateEmployee(int id, RDTOEmployee employee)
        {
            return await _repository.UpdateEmployee(id, employee);
        }

        public async Task<SDTOEmployee> GetEmployeeByCode(string code)
        {
            return await _repository.GetEmployeeByCode(code);
        }
    }
}
