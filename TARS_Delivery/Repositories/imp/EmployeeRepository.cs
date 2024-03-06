
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Helpers;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DatabaseContext databaseContext;
        private readonly IMapper mapper;
        public EmployeeRepository(DatabaseContext databaseContext, IMapper mapper)
        {
            this.databaseContext = databaseContext;
            this.mapper = mapper;
        }


        public async Task<IEnumerable<EmployeeDTO>> GetEmployees()
        {
            IEnumerable<Employee> employees = await databaseContext.Employees.ToListAsync();
            // Không thể AutoMapper một list sang một list khác -> Cần fix lại
            var employeeDTO  = mapper.Map<EmployeeDTO>(employees);
            return (IEnumerable<EmployeeDTO>)employeeDTO;
        }    


        public async Task<EmployeeDTO> GetEmployee(int id)
        {
            Employee? employee = await databaseContext.Employees.FindAsync(id);
            if (employee != null) 
            {
                var employeeDTO = mapper.Map<EmployeeDTO>(employee);
                return employeeDTO;
            }
            return null;
        }


        public async Task<EmployeeDTO> Create([FromForm] EmployeeDTO employeeDTO, IFormFile file)
        {
            Employee employee = mapper.Map<Employee>(employeeDTO);
            employeeDTO.Avatar = FileUpload.SaveFile("Avatar", file);
            await databaseContext.Employees.AddAsync(employee);
            await databaseContext.SaveChangesAsync();
            return employeeDTO;
        }

        public async Task<EmployeeDTO> Update(int id, [FromForm] EmployeeDTO employeeDTO, IFormFile file)
        {
            Employee updatedEmployee = await databaseContext.Employees.FindAsync(id);
            if (updatedEmployee != null)
            {
                if (file != null)
                {
                    if (updatedEmployee.Avatar != null)
                    {
                        FileUpload.DeleteFile(updatedEmployee.Avatar);
                    }

                    employeeDTO.Avatar = FileUpload.SaveFile("Avatar", file);
                }

                updatedEmployee.Password = employeeDTO.Password;
                updatedEmployee.Address = employeeDTO.Address;
                updatedEmployee.PhoneNumber = employeeDTO.PhoneNumber;

                await databaseContext.SaveChangesAsync();
            }

            return null;
        }


        //public async Task<Employee> Remove(int id)
        //{
        //    Employee? employee = await databaseContext.Employees.FindAsync(id);
        //    if(employee != null)
        //    {
        //        databaseContext.Employees.Remove(employee);
        //        await databaseContext.SaveChangesAsync();
        //    }
        //    return null;
        //} 

    }
}
