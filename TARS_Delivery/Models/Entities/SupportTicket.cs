using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.Entities
{
    public class SupportTicket
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public int UserId { get; set; }
        public int? EmployeeId { get; set; }
        public int PackageId { get; set; }
        public string? Photo { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public EStatusData Status { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee? Employee { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("PackageId")]
        public virtual Package Package { get; set; }
    }
}
