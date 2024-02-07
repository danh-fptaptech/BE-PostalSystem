using Microsoft.AspNetCore.Mvc;
using TARS_Delivery.Models.DTOs;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeDTO>> GetEmployees();

        Task<EmployeeDTO> GetEmployee(int id);

        Task<EmployeeDTO> Create(EmployeeDTO employeeDTO, IFormFile file);

        Task<EmployeeDTO> Update(int id, EmployeeDTO employeeDTO, IFormFile file);

    }
}
