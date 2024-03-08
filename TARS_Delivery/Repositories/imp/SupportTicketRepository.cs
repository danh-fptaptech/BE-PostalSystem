using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories.imp
{
    public class SupportTicketRepository : ISupportTicketRepository
    {
        private readonly DatabaseContext _db;

        public SupportTicketRepository(DatabaseContext db, IMapper mapper)
        {
            _db = db;
        }

        public async Task<List<RDTOSupportTicket>> GetAllSupportTicketsAsync()
        {
            return await _db.SupportTickets.Select(s => new RDTOSupportTicket
            {
                Id = s.Id,
                Title = s.Title,
                Content = s.Content,
                UserId = s.UserId,
                EmployeeId = (int)s.EmployeeId,
                CreatedAt = s.CreatedAt,
                UpdatedAt = s.UpdatedAt,
                Status = s.Status
            }).ToListAsync();
        }
        public async Task<SupportTicket> CreateSupportTicketAsync(RDTOSupportTicket supportTicket)
        {
            try
            {
                SupportTicket newTicket = new SupportTicket
                {
                    Title = supportTicket.Title,
                    Content = supportTicket.Content,
                    UserId = supportTicket.UserId,
                    EmployeeId = supportTicket.EmployeeId,
                    CreatedAt = supportTicket.CreatedAt,
                    UpdatedAt = supportTicket.UpdatedAt,
                    Status = supportTicket.Status
                };
                await _db.SupportTickets.AddAsync(newTicket);
                await _db.SaveChangesAsync();
                return newTicket;
            }
                catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Error while creating ticket !!");
            }
        }
        public async Task<SupportTicket> GetSupportTicketByIdAsync(int id)
        {
            return await _db.SupportTickets.FindAsync(id);
        }

        public async Task<SupportTicket> UpdateSupportTicketAsync(int id, SupportTicket supportTicket)
        {
            try
            {
                SupportTicket updatedTicket = await _db.SupportTickets.FindAsync(id);
                if (updatedTicket != null)
                {
                    updatedTicket.Title = supportTicket.Title;
                    updatedTicket.Content = supportTicket.Content;
                    updatedTicket.UserId = supportTicket.UserId;
                    updatedTicket.EmployeeId = supportTicket.EmployeeId;
                    updatedTicket.CreatedAt = supportTicket.CreatedAt;
                    updatedTicket.UpdatedAt = supportTicket.UpdatedAt;
                    updatedTicket.Status = supportTicket.Status;
                    await _db.SaveChangesAsync();
                    return updatedTicket;
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Error while updating ticket !!");
            }
        }

        public async Task<SupportTicket> DeleteSupportTicketAsync(int id)
        {
            try
            {
                SupportTicket ticket = await _db.SupportTickets.FindAsync(id);
                if (ticket != null)
                {
                    _db.SupportTickets.Remove(ticket);
                    await _db.SaveChangesAsync();
                    return ticket;
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Error while deleting ticket !!");
            }
        }
    }
}
