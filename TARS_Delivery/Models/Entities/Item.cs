using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Models.Entities
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PackageId { get; set; }
        public string ItemName { get; set; }
        public int ItemWeight { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemValue { get; set; }
        public EItemType ItemType { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [ForeignKey("PackageId")]
        public virtual Package Package { get; set; }

    }
}
