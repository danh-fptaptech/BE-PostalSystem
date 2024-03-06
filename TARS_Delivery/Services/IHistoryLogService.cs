using TARS_Delivery.Models.DTOs.req.HistoryLog;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Services
{
    public interface IHistoryLogService
    {
        Task<IEnumerable<HistoryLog>> GetAllHistoryLogs();
        Task<HistoryLog> GetHistoryLogById(int id);
        Task<bool> AddHistoryLog(HistoryLog historyLog);
        Task<HistoryLog> UpdateHistoryLog(int id, ListHistoryLogDTO historyLog);
        void ChangeStatusHistoryLog(int id, int status);
    }
}
