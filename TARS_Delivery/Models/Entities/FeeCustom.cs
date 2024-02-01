using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TARS_Delivery.Models.Entities
{
    public class FeeCustom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ServiceId { get; set; }
        public int LocationFrom { get; set; }
        public int LocationTo { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Distance { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public decimal FeeCharge { get; set; }
        public int TimeProcess { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [ForeignKey("ServiceId")]
        public Service Service { get; set; }
        [ForeignKey("LocationFrom")]
        public Location LocationFromObj { get; set; }
        [ForeignKey("LocationTo")]
        public Location LocationToObj { get; set; }
    }
}
