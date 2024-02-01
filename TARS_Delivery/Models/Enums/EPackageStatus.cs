namespace TARS_Delivery.Models.Enum
{
    public enum EPackageStatus
    {
        WaitingForPickup,
        Pending,
        Created,
        WarehouseFrom,
        InTransit,
        WarehouseTo,
        Delivered,
        Cancelled,
        Returned,
        Lost,
    }
}
