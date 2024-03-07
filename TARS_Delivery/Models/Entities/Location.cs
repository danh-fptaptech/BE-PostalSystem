using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.Entities
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string? PostalCode { get; set; }
        public ELocationLevel LocationLevel { get; set; }
        public int? LocationOf { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;

        public EStatusData Status { get; set; } = EStatusData.Active;

        [ForeignKey("LocationOf")]
        public virtual Location? ParentLocation { get; set; }
        public virtual ICollection<Location>? ChildLocations { get; set; }
    }
}
