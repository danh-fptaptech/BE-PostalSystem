using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<SDTOEmployee>> GetEmployees();
        Task<SDTOEmployee> GetEmployee(int id);
        Task<SDTOEmployee> GetEmployeeByCode(string code);
        Task<Employee> CreateEmployeeAsync(RDTOEmployee employee);
        Task<Employee> UpdateEmployee(int id, RDTOEmployee employee);
        Task<Employee> UpdatePassword(int id, RDTOChangePassword employee);
        Task<Employee> UpdateInfoAsync(int id, UpdateInfoAsync employee);
        Task<Employee> AcceptUpdateInfo(int id);
        Task<Employee> ChangeStatus (int id, RDTOChangeStatus employee);
        Task<IEnumerable<SDTOEmployee>> GetSubmitedInfoEmployees();
    }
}
