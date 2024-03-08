using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories
{
    public interface ISupportTicketRepository
    {
        Task<List<RDTOSupportTicket>> GetAllSupportTicketsAsync();
        Task<SupportTicket> CreateSupportTicketAsync(RDTOSupportTicket supportTicket);
        Task<SupportTicket> GetSupportTicketByIdAsync(int id);
        Task<SupportTicket> UpdateSupportTicketAsync(int id, SupportTicket supportTicket);
        Task<SupportTicket> DeleteSupportTicketAsync(int id);
    }
}
