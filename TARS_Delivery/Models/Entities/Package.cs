using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.Entities
{
    public class Package
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TrackingCode { get; set; }
        public string NameFrom { get; set; }
        public string AddressFrom { get; set; }
        public string PostalCodeFrom { get; set; }
        public string PhoneFrom { get; set; }
        public string NameTo { get; set; }
        public string AddressTo { get; set; }
        public string PostalCodeTo { get; set; }
        public string PhoneTo { get; set; }
        public int TimeProcess { get; set; }
        public EItemType PackageType { get; set; }
        public string? PackageSize { get; set; }
        public string? PackageNote { get; set; }
        public decimal TotalFee { get; set; }
        public int? COD { get; set; }
        public int FeeCustomId { get; set; }
        public int? UserId { get; set; }
        public EPackageStatus Step { get; set; } = EPackageStatus.WaitingForPickup;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public EStatusData Status { get; set; } = EStatusData.Active;


        [ForeignKey("UserId")]
        public virtual User? User { get; set; }
        [ForeignKey("FeeCustomId")]
        public virtual FeeCustom FeeCustom { get; set; }
        public virtual ICollection<Item>? Items { get; set; }
        public virtual ICollection<HistoryLog>? HistoryLogs { get; set; }
        
    }
}
