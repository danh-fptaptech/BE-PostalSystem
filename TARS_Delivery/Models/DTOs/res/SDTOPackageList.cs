namespace TARS_Delivery.Models.DTOs.res;

public class SDTOPackageList
{
    public int Id { get; set; }
    public string TrackingCode { get; set; }
    public string NameFrom { get; set; }
    public int UserId { get; set; }
    public string NameTo { get; set; }
    public string AddressTo { get; set; }
    public string PostalCodeTo { get; set; }
    public string PhoneFrom { get; set; }
    public decimal TotalFee { get; set; }
    public int CounterItem { get; set; }
}