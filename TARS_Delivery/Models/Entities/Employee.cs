using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TARS_Delivery.Models.Entities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public int PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Avatar { get; set; }
        public string Status { get; set; }
        public string SubmitedInfo { get; set; }
        public int BranchId { get; set; }
        public int RoleId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [ForeignKey("BranchId")]
        public virtual Branch Branch { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
        public virtual ICollection<HistoryLog> HistoryLogs { get; set; }
    }
}
