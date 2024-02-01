using System.ComponentModel.DataAnnotations.Schema;

namespace TARS_Delivery.Models.Entities
{
    public class RoleHasPermission
    {   
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        [ForeignKey(nameof(RoleId))]
        public virtual Role Role { get; set; }
        [ForeignKey(nameof(PermissionId))]
        public virtual Permission Permission { get; set; }
    }
}
