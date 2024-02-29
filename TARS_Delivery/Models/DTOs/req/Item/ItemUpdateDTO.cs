using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.DTOs.req.Item
{
    public class ItemUpdateDTO
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public string? ItemName { get; set; }
        public int ItemWeight { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemValue { get; set; }
        public EItemType ItemType { get; set; }
        public int BranchId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public EStatusData Status { get; set; }
    }
}
