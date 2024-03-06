namespace TARS_Delivery.Models.DTOs.req
{
    public class RDTOSetPermission
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public bool IsSet {  get; set; }
    }
}
