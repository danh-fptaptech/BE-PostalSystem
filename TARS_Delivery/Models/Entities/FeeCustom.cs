using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Models.Entities
{
    public class FeeCustom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ServiceId { get; set; }
        public int PostalCodeFrom { get; set; }
        public int PostalCodeTo { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Distance { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal FeeCharge { get; set; }
        public int TimeProcess { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public EStatusData Status { get; set; }

        [ForeignKey("ServiceId")]
        public Service? Service { get; set; }
        [ForeignKey("PostalCodeFrom")]
        public Location? LocationFrom { get; set; }
        [ForeignKey("PostalCodeTo")]
        public Location? LocationTo { get; set; }
    }
}
