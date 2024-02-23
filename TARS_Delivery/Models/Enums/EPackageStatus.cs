namespace TARS_Delivery.Models.Enums
{
    public enum EPackageStatus
    {
        WaitingForPickup = 0,
        Created = 1,
        WarehouseFrom = 2,
        InTransit = 3,
        WarehouseTo = 4,
        Shipping = 5,
        Delivered = 6,
        Cancelled = 7,
        Returned = 8,
        Lost = 9,
    }
}
