using System.ComponentModel.DataAnnotations;

namespace TARS_Delivery.Models.DTOs.req;

public class RDTOEmpPackage
{   
    [Required(ErrorMessage = "Name Sender is required")]
    public string NameFrom { get; set; }
    [Required(ErrorMessage = "Address Sender is required")]
    public string AddressFrom { get; set; }
    [Required(ErrorMessage = "Name Receiver is required")]
    public string NameTo { get; set; }
    [Required(ErrorMessage = "Address Receiver is required")]
    public string AddressTo { get; set; }
    [Required(ErrorMessage = "Postal Code Receiver is required")]
    public string PostalCodeTo { get; set; }
    
    public string? PackageNote { get; set; }
}