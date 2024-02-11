
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp
{
    public class EmployeeRepository(DatabaseContext context, IMapper mapper) : IEmployeeRepository
    {
        private readonly DatabaseContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<Employee> CheckLogin(RDTOEmployeeLogin employee)
        {
            try
            {
                var existedEmployee = await _context.Employees.FirstOrDefaultAsync(e => e.Email == employee.Email);

                if (existedEmployee != null)
                {
                    var checkPassword = await _context.Employees.FirstOrDefaultAsync(e => e.Password == employee.Password);
                    if (checkPassword != null)
                    {
                        return existedEmployee;
                    }
                    return null;
                }
                throw new Exception("The employee does not exist!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<SDTOEmployee>> GetEmployees()
        {
            IEnumerable<Employee> employees = await _context.Employees.ToListAsync();
            return _mapper.Map<IEnumerable<SDTOEmployee>>(employees);
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task<Employee> Create(Employee employee)
        {
            try
            {
                var duplicatedCode = await _context.Employees.FirstOrDefaultAsync(e => e.EmployeeCode == employee.EmployeeCode);
                var existedEmail = await _context.Employees.FirstOrDefaultAsync(e => e.Email == employee.Email);
                var existedPhone = await _context.Employees.FirstOrDefaultAsync(e => e.PhoneNumber == employee.PhoneNumber);
                
                if (duplicatedCode != null)
                {
                    throw new Exception("The employee code has already existed.");
                }

                if(existedEmail != null)
                {
                    throw new Exception("The email address has already been used.");
                }

                if(existedPhone != null)
                {
                    throw new Exception("The phone number has already been used.");
                }

                await _context.Employees.AddAsync(employee);
                await _context.SaveChangesAsync();
                return employee;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Employee> UpdatePassword(int id, RDTOChangePassword employee)
        {
            try
            {
                Employee updatedEmployee = await _context.Employees.FindAsync(id);
                if(updatedEmployee != null)
                {
                    if (!string.IsNullOrEmpty(updatedEmployee.Password))
                    {
                        var hashedPassword = PasswordHasher.HashPassword(employee.Password);
                        updatedEmployee.Password = hashedPassword;
                    }

                    updatedEmployee.UpdatedAt = DateTime.Now;

                    await _context.SaveChangesAsync();
                    return updatedEmployee;
                }

                throw new Exception("The employee does not exist !");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Employee> UpdateInfoAsync(int id, UpdateInfoAsync employee)
        {
            try
            {
                Employee updatedEmployee = await _context.Employees.FindAsync(id);
                if (updatedEmployee != null)
                {
                    updatedEmployee.SubmitedInfo = GenerateSubmitedInfo(employee);

                    await _context.SaveChangesAsync();
                    return updatedEmployee;
                }
                throw new Exception("The employee does not exist !");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Employee> AcceptUpdateInfo(int id)
        {
            try
            {
                var updatedEmployee = await _context.Employees.FindAsync(id);
                if (updatedEmployee != null)
                {
                    var submitedInfo = updatedEmployee.SubmitedInfo;
                    if (submitedInfo != null)
                    {
                        var parsedInfo = ParseSubmitedInfo(submitedInfo);
                        if (parsedInfo != null)
                        {
                            updatedEmployee.Email = parsedInfo.Email;
                            updatedEmployee.Address = parsedInfo.Address;
                            updatedEmployee.Province = parsedInfo.Province;
                            updatedEmployee.District = parsedInfo.District;
                            updatedEmployee.PhoneNumber = parsedInfo.PhoneNumber;
                            updatedEmployee.Avatar = parsedInfo.Avatar;

                            updatedEmployee.SubmitedInfo = null;
                            updatedEmployee.UpdatedAt = DateTime.Now;
                            await _context.SaveChangesAsync();
                        }
                    }
                    return updatedEmployee;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //public async Task<Employee> AcceptUpdateInfo(int id)
        //{
        //    try
        //    {
        //        var updatedEmployee = await _context.Employees.FindAsync(id);
        //        if (updatedEmployee != null)
        //        {
        //            var submitedInfo = updatedEmployee.SubmitedInfo;
        //            if (submitedInfo != null)
        //            {
        //                var parsedInfo = ParseSubmitedInfo(submitedInfo);
        //                if (parsedInfo != null)
        //                {
        //                    // check the sumitedInfo in `UpdateInfoAsync` method 
        //                    if (!string.IsNullOrEmpty(updatedEmployee.Email))
        //                        updatedEmployee.Email = parsedInfo.Email;

        //                    if (!string.IsNullOrEmpty(updatedEmployee.Address))
        //                        updatedEmployee.Address = parsedInfo.Address;

        //                    if (!string.IsNullOrEmpty(updatedEmployee.Province))
        //                        updatedEmployee.Province = parsedInfo.Province;

        //                    if (!string.IsNullOrEmpty(updatedEmployee.District))
        //                        updatedEmployee.District = parsedInfo.District;

        //                    if (!string.IsNullOrEmpty(updatedEmployee.PhoneNumber))
        //                        updatedEmployee.PhoneNumber = parsedInfo.PhoneNumber;

        //                    if (!string.IsNullOrEmpty(updatedEmployee.Avatar))
        //                        updatedEmployee.Avatar = parsedInfo.Avatar;

        //                    // Update sumitedInfo into employee object
        //                    //updatedEmployee.Email = parsedInfo.Email;
        //                    //updatedEmployee.Address = parsedInfo.Address;
        //                    //updatedEmployee.Province = parsedInfo.Province;
        //                    //updatedEmployee.District = parsedInfo.District;
        //                    //updatedEmployee.PhoneNumber = parsedInfo.PhoneNumber;
        //                    //updatedEmployee.Avatar = parsedInfo.Avatar;

        //                    updatedEmployee.SubmitedInfo = null;
        //                    updatedEmployee.UpdatedAt = DateTime.Now;
        //                    await _context.SaveChangesAsync();
        //                }
        //            }
        //            return updatedEmployee;
        //        }
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        private static string GenerateSubmitedInfo(UpdateInfoAsync employee)
        {
            string submitedInfo =
            $"Email: {employee.Email}, " +
            $"Address: {employee.Address}, " +
            $"Province: {employee.Province}, " +
            $"District: {employee.District}, " +
            $"PhoneNumber: {employee.PhoneNumber}, " +
            $"Avatar: {employee.Avatar} ";

            return submitedInfo;
        }

        //private static string GenerateSubmitedInfo(UpdateInfoAsync employee)
            //{
            //    var submittedInfo = new List<string>();

            //    if (!string.IsNullOrEmpty(employee.Email))
            //        submittedInfo.Add($"Email: {employee.Email}");

            //    if (!string.IsNullOrEmpty(employee.Address))
            //        submittedInfo.Add($"Address: {employee.Address}");

            //    if (!string.IsNullOrEmpty(employee.Province))
            //        submittedInfo.Add($"Province: {employee.Province}");

            //    if (!string.IsNullOrEmpty(employee.District))
            //        submittedInfo.Add($"District: {employee.District}");

            //    if (!string.IsNullOrEmpty(employee.PhoneNumber))
            //        submittedInfo.Add($"PhoneNumber: {employee.PhoneNumber}");

            //    if (!string.IsNullOrEmpty(employee.Avatar))
            //        submittedInfo.Add($"Avatar: {employee.Avatar}");

            //    return string.Join(", ", submittedInfo);
            //}

        private static SubmitedInfo ParseSubmitedInfo(string submittedInfo)
        {
            string[] infoParts = submittedInfo.Split(", ");
            var submitedInfo = new SubmitedInfo();

            foreach (var part in infoParts)
            {
                var keyValue = part.Split(": ");
                var key = keyValue[0];
                var value = keyValue[1];

                switch (key)
                {
                    case "Email":
                        submitedInfo.Email = value;
                        break;
                    case "Address":
                        submitedInfo.Address = value;
                        break;
                    case "Province":
                        submitedInfo.Province = value;
                        break;
                    case "District":
                        submitedInfo.District = value;
                        break;
                    case "PhoneNumber":
                        submitedInfo.PhoneNumber = value;
                        break;
                    case "Avatar":
                        submitedInfo.Avatar = value;
                        break;
                    default:
                        // Handle unrecognized keys or invalid format
                        return null;
                }
            }

            return submitedInfo;
        }

        public class SubmitedInfo
        {
            public string? Email { get; set; }
            public string? Address { get; set; }
            public string? Province { get; set; }
            public string? District { get; set; }
            public string? PhoneNumber { get; set; }
            public string? Avatar { get; set; }
        }
    }
}
