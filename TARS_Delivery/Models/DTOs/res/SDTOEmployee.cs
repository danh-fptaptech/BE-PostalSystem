using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.DTOs.res
{
    public class SDTOEmployee
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string PhoneNumber { get; set; }
        public string Avatar { get; set; }
        public string? SubmitedInfo { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public EStatusData Status { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public virtual Role? Role { get; set; }
        public virtual Branch? Branch { get; set; }
        public virtual ICollection<HistoryLog>? HistoryLogs { get; set; }

    }
}
