using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Services.Users.Query.GetUsersWithPackagesAsync;

internal record PackageResponse(
    int Id, 
    string TrackingCode, 
    string NameFrom, 
    string AddressFrom, 
    string PostalCodeFrom, 
    string NameTo, 
    string AddressTo, 
    string PostalCodeTo, 
    string? PackageSize, 
    string? PackageNote, 
    decimal TotalFee, 
    int ServiceId,
    EPackageStatus Step, 
    EStatusData Status);