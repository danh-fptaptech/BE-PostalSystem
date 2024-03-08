using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.Entities
{
    public class HistoryLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int PackageId { get; set; }
        public int? EmployeeId { get; set; }
        public EPackageStatus Step { get; set; }
        public string? HistoryNote { get; set; }
        public string? Photos { get; set; }
        public EStep ProcessStep { get; set; } = EStep.Hold;
        public int? EmployeeIdNextStep { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public EStatusData Status { get; set; } = EStatusData.Active;

        // Navigation properties
        [ForeignKey("PackageId")]
        public virtual Package? Package { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee? Employee { get; set; }
        
        [ForeignKey("EmployeeIdNextStep")]
        public virtual Employee? EmployeeNextStep { get; set; }
    }
}
