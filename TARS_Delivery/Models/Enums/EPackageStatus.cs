namespace TARS_Delivery.Models.Enums
{
    public enum EPackageStatus
    {
        WaitingForPickup = 0,
        Pending = 1,
        Created = 2,
        WarehouseFrom = 3,
        InTransit = 4,
        WarehouseTo = 5,
        Delivered = 6,
        Cancelled = 7,
        Returned = 8,
        Lost = 9,
    }
}
