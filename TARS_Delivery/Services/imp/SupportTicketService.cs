using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp
{
    public class SupportTicketService : ISupportTicketService
    {
        private readonly ISupportTicketRepository _supportTicketRepository;
        public SupportTicketService(ISupportTicketRepository supportTicketRepository)
        {
            _supportTicketRepository = supportTicketRepository;
        }
        public async Task<SupportTicket> CreateSupportTicketAsync(RDTOSupportTicket supportTicket)
        {
            return await _supportTicketRepository.CreateSupportTicketAsync(supportTicket);
        }
        public async Task<SupportTicket> DeleteSupportTicketAsync(int id)
        {
            return await _supportTicketRepository.DeleteSupportTicketAsync(id);
        }
        public async Task<List<RDTOSupportTicket>> GetAllSupportTicketsAsync()
        {
            return await _supportTicketRepository.GetAllSupportTicketsAsync();
        }
        public async Task<SupportTicket> GetSupportTicketByIdAsync(int id)
        {
            return await _supportTicketRepository.GetSupportTicketByIdAsync(id);
        }
        public async Task<SupportTicket> UpdateSupportTicketAsync(int id, SupportTicket supportTicket)
        {
            return await _supportTicketRepository.UpdateSupportTicketAsync(id, supportTicket);
        }
    }
}
