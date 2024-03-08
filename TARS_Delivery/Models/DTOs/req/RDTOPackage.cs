using System.ComponentModel.DataAnnotations;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.DTOs.req;

public class RDTOPackage
{   
    [Required(ErrorMessage = "Name Sender is required")]
    public string NameFrom { get; set; }
    [Required(ErrorMessage = "Phone Sender is required")]
    public string PhoneFrom { get; set; }
    [Required(ErrorMessage = "Address Sender is required")]
    public string AddressFrom { get; set; }
    [Required(ErrorMessage = "Postal Code Sender is required")]
    public string PostalCodeFrom { get; set; }
    [Required(ErrorMessage = "Name Receiver is required")]
    public string NameTo { get; set; }
    [Required(ErrorMessage = "Phone Receiver is required")]
    public string PhoneTo { get; set; }
    [Required(ErrorMessage = "Address Receiver is required")]
    public string AddressTo { get; set; }
    [Required(ErrorMessage = "Postal Code Receiver is required")]
    public string PostalCodeTo { get; set; }
    public string? PackageNote { get; set; }
    public string? PackageSize { get; set; }
    public int FeeCustomId { get; set; }
    public string? EmployeeCode { get; set; }
    public int? UserId { get; set; }
    public int? EmployeeId { get; set; }
    [Required(ErrorMessage = "Total Fee is required")]
    public decimal TotalFee { get; set; }
    public int COD { get; set; }
    public EItemType PackageType { get; set; }
    public int TimeProcess { get; set; }
    public EPackageStatus Step { get; set; }
    public ICollection<Entities.Item> Items { get; set; }
}