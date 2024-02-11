
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<SDTOEmployee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<Employee> Create(Employee employee);
        Task<Employee> UpdatePassword(int id, RDTOChangePassword employee);
        Task<Employee> UpdateInfoAsync(int id, UpdateInfoAsync employee);
        Task<Employee> AcceptUpdateInfo(int id);
        Task<Employee> CheckLogin(RDTOEmployeeLogin employee);

    }
}
