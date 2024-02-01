using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Models.Entities;

public class User
{
    private readonly List<Customer> _customers = [];
    private readonly List<Package> _packages = [];

    private User(
        string fullname, 
        string email, 
        string password) 
        {
            Fullname = fullname;
            Email = email;
            Password = password;
            CreatedAt = DateTime.Now;
            Status = EStatusData.Active;
        }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; private set; }

    [Required]
    public string Fullname { get; private set; }

    [Required]
    public string Email { get; private set; }

    [Required]
    public string Password { get; private set; }

    public string Phone { get; private set; } = string.Empty;

    public string Avatar { get; private set; } = string.Empty;

    public DateTime CreatedAt { get; private set; }

    public DateTime? UpdatedAt { get; private set; }

    public EStatusData Status { get; private set; }

    // Relation with Customer
    public ICollection<Customer> Customers => _customers;

    // Relation with Package
    public ICollection<Package> Packages => _packages;

    public static User RegisterUser(
        string fullname,
        string email,
        string password) => 
            new(
                fullname,
                email,
                password);
}