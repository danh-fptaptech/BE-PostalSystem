using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<SDTOEmployee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<Employee> Create(RDTOEmployee employee);
        Task<Employee> UpdatePassword(int id, UpdatePassword employee);
        Task<Employee> UpdateInfoAsync(int id, EmployeeUpdateInfo employee);
        Task<Employee> CheckLogin(RDTOEmployeeLogin employee);
    }
}
