using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TARS_Delivery.Models;
using TARS_Delivery.Models.DTOs.req.HistoryLog;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Repositories.imp
{
    public class HistoryLogRepository : IHistoryLogRepository
    {
        private readonly DatabaseContext _context;

        public HistoryLogRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HistoryLog>> GetAllHistoryLogs()
        {
            return await _context.HistoryLogs.ToListAsync();
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

        public async Task<bool> AddHistoryLog(HistoryLog historyLog)
        {
            try
            {
                _context.HistoryLogs.Add(historyLog);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
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

        /*public async Task UpdateStep(int id, EPackageStatus newStep)
        {
            var historyLog = await GetHistoryLogById(id);
            if (historyLog != null)
            {
                historyLog.Step = newStep;
                await _context.SaveChangesAsync();
            }
        }*/

        /*public async Task UpdateProcessStep(int id, EStep newProcessStep)
        {
            var historyLog = await GetHistoryLogById(id);
            if (historyLog != null)
            {
                historyLog.ProcessStep = newProcessStep;
                await _context.SaveChangesAsync();
            }
        }*/
    }
}
