using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.Entities;

public class User
{
    private readonly List<Customer> _customers = [];
    private readonly List<Package> _packages = [];

    private User(
        string fullname, 
        string email, 
        string phone,
        string password) 
        {
            Fullname = fullname;
            Email = email;
            Phone = phone;
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

    public string Phone { get; private set; }

    public string? Avatar { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public DateTime? UpdatedAt { get; private set; }

    public EStatusData Status { get; private set; }

    public string? RefreshToken { get; private set; }

    public DateTime? RefreshTokenExpires { get; private set; }

    public string? PasswordResetToken { get; private set; }

    public DateTime? ResetTokenExpires {  get; private set; }

    // Relation with Customer
    public IReadOnlyCollection<Customer> Customers => _customers;

    // Relation with Package
    public IReadOnlyCollection<Package> Packages => _packages;
    public virtual ICollection<SupportTicket>? SupportTickets { get; set; }


    public static User Register(
        string fullname,
        string email,
        string phone,
        string password) => 
            new(
                fullname,
                email,
                phone,
                password);

    public void ChangePassword(string password)
    {
        Password = password;
        UpdatedAt = DateTime.Now;
    }

    public void ResetPassword(string password)
    {
        ChangePassword(password);
        ResetTokenExpires = null;
        PasswordResetToken = null;
    }

    public void AddCustomer(
            string name,
            string phoneNumber,
            string address,
            string city,
            string district,
            string ward,
            string postalCode,
            ETypeInfo typeInfo)
    {
        Customer customer = Customer.CreateCustomer(
            Id,
            name,
            phoneNumber,
            address,
            city,
            district,
            ward,
            postalCode,
            typeInfo);
        
        _customers.Add(customer);

        UpdatedAt = DateTime.Now;
    }

    public void GenerateRefreshToken(HttpContext httpContext)
    {
        RefreshToken = Convert.ToBase64String(
            RandomNumberGenerator.GetBytes(64));

        RefreshTokenExpires = DateTime.Now.AddDays(7);

        CookieOptions options = new()
        {
            HttpOnly = true,
            Expires = RefreshTokenExpires,
        };

        httpContext
            .Response
            .Cookies
            .Append("refresh-token", RefreshToken, options);
    }

    public void RevokeToken()
    {
        RefreshToken = null;
        RefreshTokenExpires = null;
        UpdatedAt = DateTime.Now;
    }

    internal static User Seed(
        int id,
        string fullname,
        string email,
        string phone,
        string password)
    {
        User user = Register(fullname, email, phone, password);
        user.Id = id;

        return user;
    }

    public string GeneratePasswordResetToken()
    {
        PasswordResetToken = Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        ResetTokenExpires = DateTime.Now.AddDays(1);
        UpdatedAt = DateTime.Now;

        return PasswordResetToken;
    }

    public void UpdateProfile(string fullname, string phone)
    {
        Fullname = fullname;
        Phone = phone;
        UpdatedAt = DateTime.Now;
    }

    public void UpdateAvatar(string avatar)
    {
        Avatar = avatar;
        UpdatedAt = DateTime.Now;
    }

    public void ChangeStatus()
    {
        if (Status == EStatusData.Active)
        {
            Status = EStatusData.Inactive;
        }
        else
        {
            Status = EStatusData.Active;
        }
        UpdatedAt = DateTime.Now;
    }
}