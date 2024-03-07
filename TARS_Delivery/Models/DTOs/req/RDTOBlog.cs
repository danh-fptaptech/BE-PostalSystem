using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.DTOs.req
{
    public class RDTOBlog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public required string Title { get; set; }
        [Required]
        public required string Slug { get; set; }
        [Required(ErrorMessage = "Content is required")]
        public required string Content { get; set; }
        [Required(ErrorMessage = "Author is required")]
        public required string Author { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public ECategory Category { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public EStatusData Status { get; set; }
    }
}
