
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Text;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.DTOs.res;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp
{
    public class EmployeeRepository(DatabaseContext context, IMapper mapper) : IEmployeeRepository
    {
        private readonly DatabaseContext _context = context;
        //private readonly IMapper _mapper = mapper;


        public async Task<IEnumerable<SDTOEmployee>> GetEmployees()
        {
            IEnumerable<Employee> employees = await _context.Employees
                .Include(e => e.Role) // get all information from Entity<Role>
                .Include(e => e.Branch)
                .Include(e => e.HistoryLogs)
                .ToListAsync();

            IEnumerable<SDTOEmployee> dtoEmployees = employees.Select(e => new SDTOEmployee
            {
                Id = e.Id,
                EmployeeCode = e.EmployeeCode,
                Email = e.Email,
                Password = e.Password,
                Fullname = e.Fullname,
                Address = e.Address,
                Province = e.Province,
                District = e.District,
                PhoneNumber = e.PhoneNumber,
                Avatar = e.Avatar,
                SubmitedInfo = e.SubmitedInfo,
                CreatedAt = e.CreatedAt,
                UpdatedAt = e.UpdatedAt,
                Status = e.Status,
                BranchId = e.BranchId,
                BranchName = e.Branch.BranchName,
                RoleId = e.RoleId,
                RoleName = e.Role.RoleName, // get RoleName
                HistoryLogs = e.HistoryLogs.Select(h => new HistoryLog
                {
                    Id = h.Id,
                    PackageId = h.PackageId,
                    EmployeeId = h.EmployeeId,
                    Step = h.Step,
                    HistoryNote = h.HistoryNote,
                    Photos = h.Photos,
                    CreatedAt = h.CreatedAt,
                    UpdatedAt = h.UpdatedAt,
                    Status = h.Status,
                }).ToList()
            });

            return dtoEmployees;
        }

        public async Task<SDTOEmployee> GetEmployee(int id)
        {
            var employee = await _context.Employees
            .Include(e => e.Role)
            .Include(e => e.Branch)
            .Include(e => e.HistoryLogs)
            .FirstOrDefaultAsync(e => e.Id == id);

            if (employee != null)
            {
                SDTOEmployee dtoEmployee = new()
                {
                    Id = employee.Id,
                    EmployeeCode = employee.EmployeeCode,
                    Fullname = employee.Fullname,
                    Email = employee.Email,
                    Password = employee.Password,
                    PhoneNumber = employee.PhoneNumber,
                    Address = employee.Address,
                    Province = employee.Province,
                    District = employee.District,
                    Avatar = employee.Avatar,
                    SubmitedInfo = employee.SubmitedInfo,
                    CreatedAt = employee.CreatedAt,
                    Status = employee.Status,
                    BranchId = employee.BranchId,
                    BranchName = employee.Branch.BranchName,
                    RoleId = employee.RoleId,
                    RoleName = employee.Role.RoleName,
                    HistoryLogs = employee.HistoryLogs.Select(h => new HistoryLog
                    {
                        Id = h.Id,
                        PackageId = h.PackageId,
                        EmployeeId = h.EmployeeId,
                        Step = h.Step,
                        HistoryNote = h.HistoryNote,
                        Photos = h.Photos,
                        CreatedAt = h.CreatedAt,
                        UpdatedAt = h.UpdatedAt,
                        Status = h.Status,
                    }).ToList()
                };
                return dtoEmployee;
            }
            throw new Exception("The employee does not exist !");
        }

        public async Task<Employee> CreateEmployeeAsync(Employee employee)
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

                if (existedEmail != null)
                {
                    throw new Exception("The email address has already been used.");
                }

                if (existedPhone != null)
                {
                    throw new Exception("The phone number has already been used.");
                }

                await _context.Employees.AddAsync(employee);
                await _context.SaveChangesAsync();
                return employee;
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }
        }

        public async Task<Employee> UpdateEmployee(int id, RDTOEmployee employee)
        {
            try
            {
                var updatedEmployee = await _context.Employees.FindAsync(id);
                if (updatedEmployee != null)
                {
                    updatedEmployee.Fullname = employee.Fullname;
                    updatedEmployee.Email = employee.Email;
                    updatedEmployee.Password = employee.Password;
                    updatedEmployee.Address = employee.Address;
                    updatedEmployee.District = employee.District;
                    updatedEmployee.Province = employee.Province;
                    updatedEmployee.PhoneNumber = employee.PhoneNumber;
                    updatedEmployee.BranchId = employee.BranchId;
                    updatedEmployee.RoleId = employee.RoleId;

                    await _context.SaveChangesAsync();
                    return updatedEmployee;
                }
                throw new Exception("The employee doesn't exist !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }
        }

        public async Task<Employee> ChangeStatus(int id, RDTOChangeStatus employee)
        {
            try
            {
                var UpdatedEmployee = await _context.Employees.FindAsync(id);
                if (UpdatedEmployee != null)
                {
                    UpdatedEmployee.Status = employee.Status;

                    UpdatedEmployee.UpdatedAt = DateTime.Now;
                    await _context.SaveChangesAsync();
                    return UpdatedEmployee;
                }
                throw new Exception("The employee does not exist !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }
        }

        public async Task<Employee> UpdateInfoAsync(int id, UpdateInfoAsync employee)
        {
            try
            {
                var updatedEmployee = await _context.Employees.FindAsync(id);
                if (updatedEmployee != null && updatedEmployee.Role.RoleName != "Admin")
                {   
                    // get oldValue 
                    string oldEmail = updatedEmployee.Email;
                    string oldAddress = updatedEmployee.Address;
                    string oldProvince = updatedEmployee.Province;
                    string oldDistrict = updatedEmployee.District;
                    string oldPhoneNumber = updatedEmployee.PhoneNumber;
                    string oldAvatar = updatedEmployee.Avatar;

                    updatedEmployee.SubmitedInfo = GenerateSubmitedInfo(employee, oldEmail, oldAddress, oldProvince, oldDistrict, oldPhoneNumber, oldAvatar);

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

        public async Task<IEnumerable<SDTOEmployee>> GetSubmitedInfoEmployees()
        {
            IEnumerable<Employee> employees = await _context.Employees
                .Where(e => e.SubmitedInfo != null)
                .Include(e => e.Role) // get all information from Entity<Role>
                .Include(e => e.Branch)
                .Include(e => e.HistoryLogs)
                .ToListAsync();

            IEnumerable<SDTOEmployee> dtoEmployees = employees.Select(e => new SDTOEmployee
            {
                Id = e.Id,
                EmployeeCode = e.EmployeeCode,
                Email = e.Email,
                Password = e.Password,
                Fullname = e.Fullname,
                Address = e.Address,
                Province = e.Province,
                District = e.District,
                PhoneNumber = e.PhoneNumber,
                Avatar = e.Avatar,
                SubmitedInfo = e.SubmitedInfo,
                CreatedAt = e.CreatedAt,
                UpdatedAt = e.UpdatedAt,
                Status = e.Status,
                BranchId = e.BranchId,
                BranchName = e.Branch.BranchName,
                RoleId = e.RoleId,
                RoleName = e.Role.RoleName, // get RoleName
                HistoryLogs = e.HistoryLogs.Select(h => new HistoryLog
                {
                    Id = h.Id,
                    PackageId = h.PackageId,
                    EmployeeId = h.EmployeeId,
                    Step = h.Step,
                    HistoryNote = h.HistoryNote,
                    Photos = h.Photos,
                    CreatedAt = h.CreatedAt,
                    UpdatedAt = h.UpdatedAt,
                    Status = h.Status,
                }).ToList()
            });

            return dtoEmployees;
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
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }
        }

        private static string GenerateSubmitedInfo(UpdateInfoAsync updatedInfo, 
            string oldEmail, string oldAddress, string oldProvince, string oldDistrict, 
            string oldPhoneNumber, string oldAvatar)
        {
            StringBuilder submittedInfoBuilder = new();

            if (updatedInfo.Email != null && updatedInfo.Email != oldEmail)
                submittedInfoBuilder.Append($"Email: {updatedInfo.Email}, ");
            else
                submittedInfoBuilder.Append($"Email: {oldEmail}, ");

            if (updatedInfo.Address != null && updatedInfo.Address != oldAddress)
                submittedInfoBuilder.Append($"Address: {updatedInfo.Address}, ");
            else
                submittedInfoBuilder.Append($"Address: {oldAddress}, ");

            if (updatedInfo.Province != null && updatedInfo.Province != oldProvince)
                submittedInfoBuilder.Append($"Province: {updatedInfo.Province}, ");
            else
                submittedInfoBuilder.Append($"Province: {oldProvince}, ");

            if (updatedInfo.District != null && updatedInfo.District != oldDistrict)
                submittedInfoBuilder.Append($"District: {updatedInfo.District}, ");
            else
                submittedInfoBuilder.Append($"District: {oldDistrict}, ");

            if (updatedInfo.PhoneNumber != null && updatedInfo.PhoneNumber != oldPhoneNumber)
                submittedInfoBuilder.Append($"PhoneNumber: {updatedInfo.PhoneNumber}, ");
            else
                submittedInfoBuilder.Append($"PhoneNumber: {oldPhoneNumber}, ");

            if (updatedInfo.Avatar != null && updatedInfo.Avatar != oldAvatar)
                submittedInfoBuilder.Append($"Avatar: {updatedInfo.Avatar}");
            else
                submittedInfoBuilder.Append($"Avatar: {oldAvatar}");

            return submittedInfoBuilder.ToString();
        }

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

        public async Task<SDTOEmployee> GetEmployeeByCode(string code)
        {
            var employee = await _context.Employees
            .Include(e => e.Role)
            .Include(e => e.Branch)
            .Include(e => e.HistoryLogs)
            .FirstOrDefaultAsync(e => e.EmployeeCode == code);

            if (employee != null)
            {
                SDTOEmployee dtoEmployee = new()
                {
                    Id = employee.Id,
                    EmployeeCode = employee.EmployeeCode,
                    Fullname = employee.Fullname,
                    Email = employee.Email,
                    Password = employee.Password,
                    PhoneNumber = employee.PhoneNumber,
                    Address = employee.Address,
                    Province = employee.Province,
                    District = employee.District,
                    Avatar = employee.Avatar,
                    SubmitedInfo = employee.SubmitedInfo,
                    CreatedAt = employee.CreatedAt,
                    Status = employee.Status,
                    BranchId = employee.BranchId,
                    BranchName = employee.Branch.BranchName,
                    RoleId = employee.RoleId,
                    RoleName = employee.Role.RoleName,
                    HistoryLogs = employee.HistoryLogs.Select(h => new HistoryLog
                    {
                        Id = h.Id,
                        PackageId = h.PackageId,
                        EmployeeId = h.EmployeeId,
                        Step = h.Step,
                        HistoryNote = h.HistoryNote,
                        Photos = h.Photos,
                        CreatedAt = h.CreatedAt,
                        UpdatedAt = h.UpdatedAt,
                        Status = h.Status,
                    }).ToList()
                };
                return dtoEmployee;
            }
            throw new Exception("The employee does not exist !");
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
