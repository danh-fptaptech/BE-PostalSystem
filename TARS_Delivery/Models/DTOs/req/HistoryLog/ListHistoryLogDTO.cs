using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.DTOs.req.HistoryLog
{
    public class ListHistoryLogDTO
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public int EmployeeId { get; set; }
        [DefaultValue(EPackageStatus.WaitingForPickup)]
        public EPackageStatus Step { get; set; }
        public string? HistoryNote { get; set; }
        public string? Photos { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public EStatusData Status { get; set; }
    }
}
