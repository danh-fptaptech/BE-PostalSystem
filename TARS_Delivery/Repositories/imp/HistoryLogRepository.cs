using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req.HistoryLog;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Repositories.imp
{
    public class HistoryLogRepository : IHistoryLogRepository
    {
        private readonly DatabaseContext _context;

        public HistoryLogRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ListHistoryLogDTO>> GetAllHistoryLogs()
        {
            return await _context.HistoryLogs
                .Select(hl => new ListHistoryLogDTO
                {
                    Id = hl.Id,
                    PackageId = hl.PackageId,
                    EmployeeId = hl.EmployeeId,
                    Step = hl.Step,
                    HistoryNote = hl.HistoryNote,
                    Photos = hl.Photos,
                    CreatedAt = (DateTime)hl.CreatedAt,
                    UpdatedAt = (DateTime)hl.UpdatedAt,
                    Status = hl.Status
                })
                .ToListAsync();
        }

        public async Task<HistoryLog> GetHistoryLogById(int id)
        {
            try
            {
                return await _context.HistoryLogs
                    .SingleOrDefaultAsync(hl => hl.Id == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<HistoryLog> AddHistoryLog(ListHistoryLogDTO historyLog)
        {
            try
            {
                var newHistoryLog = new HistoryLog
                {
                    PackageId = historyLog.PackageId,
                    EmployeeId = historyLog.EmployeeId,
                    Step = historyLog.Step,
                    HistoryNote = historyLog.HistoryNote,
                    Photos = historyLog.Photos,
                    CreatedAt = historyLog.CreatedAt,
                    UpdatedAt = historyLog.UpdatedAt,
                    Status = historyLog.Status
                };

                _context.HistoryLogs.Add(newHistoryLog);
                await _context.SaveChangesAsync();

                return newHistoryLog;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<HistoryLog> UpdateHistoryLog(int id, ListHistoryLogDTO historyLog)
        {
            try
            {
                var historyLogToUpdate = await _context.HistoryLogs
                    .Where(hl => hl.Id == id)
                    .FirstOrDefaultAsync();

                if (historyLogToUpdate == null)
                {
                    throw new Exception("HistoryLog not found");
                }

                historyLogToUpdate.PackageId = historyLog.PackageId;
                historyLogToUpdate.EmployeeId = historyLog.EmployeeId;
                historyLogToUpdate.Step = historyLog.Step;
                historyLogToUpdate.HistoryNote = historyLog.HistoryNote;
                historyLogToUpdate.Photos = historyLog.Photos;
                historyLogToUpdate.UpdatedAt = historyLog.UpdatedAt;
                historyLogToUpdate.Status = historyLog.Status;

                await _context.SaveChangesAsync();

                return historyLogToUpdate;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void ChangeStatusHistoryLog(int id, int status)
        {
            try
            {
                var historyLog = _context.HistoryLogs
                    .Where(hl => hl.Id == id)
                    .FirstOrDefault();

                if (historyLog == null)
                {
                    throw new Exception("HistoryLog not found");
                }

                historyLog.Status = (EStatusData)status;

                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
