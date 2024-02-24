using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDTO>> GetEmployees();

        Task<EmployeeDTO> GetEmployee(int id);

        Task<EmployeeDTO> Create(EmployeeDTO employeeDTO, IFormFile file);

        Task<EmployeeDTO> Update(int id, EmployeeDTO employeeDTO, IFormFile file);
    }
}
