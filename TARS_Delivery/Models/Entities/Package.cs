﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enum;

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
        public int PostalCodeFrom { get; set; }
        public string NameTo { get; set; }
        public string AddressTo { get; set; }
        public int PostalCodeTo { get; set; }
        public string PackageNote { get; set; }
        public decimal TotalFee { get; set; }
        public string Photos { get; set; }
        public int ServiceId { get; set; }
        public int UserId { get; set; }
        public EPackageStatus Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;



        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("ServiceId")]
        public virtual Service Service { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<HistoryLog> HistoryLogs { get; set; }
    }
}
