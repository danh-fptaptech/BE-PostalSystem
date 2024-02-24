using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.Entities
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int PackageId { get; set; }
        [Required]
        public string? ItemName { get; set; }
        [Required]
        [Range(1, 100)]
        public int ItemWeight { get; set; }
        [Required]
        public int ItemQuantity { get; set; }
        [Required]
        public decimal ItemValue { get; set; }
        [Required]
        public EItemType ItemType { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public EStatusData Status { get; set; }
        
        [ForeignKey("PackageId")]
        public virtual Package Package { get; set; }
    }
}
