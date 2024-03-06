using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;
using TARS_Delivery.Providers;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp
{
    public class EmployeeService : IEmployeeService
    { 
        private readonly IEmployeeRepository _repository;
        private readonly IHashProvider _hashProvider;

        public EmployeeService(IEmployeeRepository repository, IHashProvider hashProvider)
        {
            _repository = repository;
            _hashProvider = hashProvider;
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
                Password = _hashProvider.Hash(employee.Password),
                Fullname = employee.Fullname,
                PostalCode = employee.PostalCode,
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

        public async Task<Employee> UpdatePassword(string code, RDTOChangePassword employee)
        {
            var updatedEmployee = await _repository.GetEmployeeByCode(code);
            if (updatedEmployee == null)
            {
                throw new Exception("Employee not found !");
            }
            else
            {
                if (_hashProvider.Verify(employee.OldPassword, updatedEmployee.Password))
                {
                    string newPassword = _hashProvider.Hash(employee.NewPassword);
                    return await _repository.UpdatePassword(code, newPassword);
                }
                throw new Exception("Incorrect password !");

            }
        }

        public async Task<Employee> UpdateInfoAsync(string code, UpdateInfoAsync employee)
        {
            return await _repository.UpdateInfoAsync(code, employee);
        }

        public Task<Employee> AcceptUpdateInfo(int id)
        {
            return _repository.AcceptUpdateInfo(id);
        }

        public async Task<Employee> ChangeStatus(int id)
        {
            var updateedEmployee = await _repository.GetEmployee(id);
            if (updateedEmployee == null)
            {
                throw new Exception("The employee does not exist !");
            }
            return await _repository.ChangeStatus(id);
        }

        public async Task<IEnumerable<SDTOEmployee>> GetSubmitedInfoEmployees()
        {
            return await _repository.GetSubmitedInfoEmployees();
        }

        public async Task<Employee> UpdateEmployee(string code, RDTOUpdateEmployee employee)
        {
            return await _repository.UpdateEmployee(code, employee);
        }

        public async Task<SDTOEmployee> GetEmployeeByCode(string code)
        {
            return await _repository.GetEmployeeByCode(code);
        }

        public Task<Employee> RejectUpdateInfo(int id)
        {
            return _repository.RejectUpdateInfo(id);
        }

        public async Task<IEnumerable<SDTOEmployee>> GetEmployeesByBranch(string branchName)
        {
            return await _repository.GetEmployeesByBranch(branchName);
        }
    }
}
