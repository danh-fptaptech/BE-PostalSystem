using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.Entities
{
    public class FeeCustom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int LocationIdFrom { get; set; }
        public int LocationIdTo { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? OverWeightCharge { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal FeeCharge { get; set; }
        public int TimeProcess { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public EStatusData Status { get; set; }

        [ForeignKey("ServiceId")]
        public Service? Service { get; set; }
        [ForeignKey("LocationIdFrom")]
        public Location? LocationFrom { get; set; }
        [ForeignKey("LocationIdTo")]
        public Location? LocationTo { get; set; }
    }
}
