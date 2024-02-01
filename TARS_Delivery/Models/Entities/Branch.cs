using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Models.Entities
{
    public class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string BranchName { get; set; }
        
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
        
        public string Province { get; set; }
        
        public string City { get; set; }

        public string District { get; set; }

        public int PostalCode { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public EStatusData Status { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<Item> Items { get; set; }
        
    }
}
