using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TARS_Delivery.Models.Entities;

public class UserRegistrationInfo
{
    private UserRegistrationInfo(
        string fullname, 
        string email, 
        string password, 
        string phone, 
        string otp) 
    { 
        Fullname = fullname;
        Email = email;
        Password = password;
        Phone = phone;
        Otp = otp;
        CreatedAt = DateTime.Now;
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

    public string Phone { get; private set; }

    public string? Avatar { get; private set; }

    public string Otp { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public static UserRegistrationInfo Create(
        string fullname,
        string email,
        string password,
        string phone,
        string otp)
    {
        return new(fullname, email, password, phone, otp);
    }

    public User Register()
    {
        return User.Register(Fullname, Email, Phone, Password);
    }
}
