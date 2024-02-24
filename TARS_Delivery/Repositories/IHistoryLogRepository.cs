using TARS_Delivery.Models.DTOs.req.HistoryLog;
using TARS_Delivery.Models.Entities;

namespace TARS_Delivery.Repositories
{
    public interface IHistoryLogRepository
    {
        Task<IEnumerable<ListHistoryLogDTO>> GetAllHistoryLogs();
        Task<HistoryLog> GetHistoryLogById(int id);
        Task<HistoryLog> AddHistoryLog(ListHistoryLogDTO historyLog);
        Task<HistoryLog> UpdateHistoryLog(int id, ListHistoryLogDTO historyLog);
        void ChangeStatusHistoryLog(int id, int status);
    }
}
