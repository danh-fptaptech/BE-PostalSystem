using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enum;

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

        public static implicit operator Role(List<Role> v)
        {
            throw new NotImplementedException();
        }
    }
}
