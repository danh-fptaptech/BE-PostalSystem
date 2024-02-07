using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Models.Entities
{
    public class HistoryLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PackageId { get; set; }
        public int EmployeeId { get; set; }
        public EPackageStatus Step { get; set; }
        public string? HistoryNote { get; set; }
        public string? Photos { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public EStatusData Status { get; set; }

        // Navigation properties
        [ForeignKey("PackageId")]
        public virtual Package Package { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
