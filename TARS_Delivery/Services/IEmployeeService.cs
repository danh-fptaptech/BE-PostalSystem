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
        Task<Employee> UpdateEmployee(string code, RDTOUpdateEmployee employee);
        Task<Employee> UpdatePassword(string code, RDTOChangePassword employee);
        Task<Employee> UpdateInfoAsync(string code, UpdateInfoAsync employee);
        Task<Employee> AcceptUpdateInfo(int id);
        Task<Employee> RejectUpdateInfo(int id);
        Task<Employee> ChangeStatus (int id);
        Task<IEnumerable<SDTOEmployee>> GetSubmitedInfoEmployees();
        Task<IEnumerable<SDTOEmployee>> GetEmployeesByBranch(string branchName);
    }
}
