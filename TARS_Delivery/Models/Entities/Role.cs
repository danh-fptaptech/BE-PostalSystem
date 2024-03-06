using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.Entities
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<RoleHasPermission>? RoleHasPermissions { get; set; }
        public EStatusData Status { get; set; }
    }
}
