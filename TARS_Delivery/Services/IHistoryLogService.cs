using TARS_Delivery.Models.DTOs.req.HistoryLog;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Services
{
    public interface IHistoryLogService
    {
        Task<IEnumerable<ListHistoryLogDTO>> GetAllHistoryLogs();
        Task<HistoryLog> GetHistoryLogById(int id);
        Task<HistoryLog> AddHistoryLog(ListHistoryLogDTO historyLog);
        Task<HistoryLog> UpdateHistoryLog(int id, ListHistoryLogDTO historyLog);
        void ChangeStatusHistoryLog(int id, int status);
        //Task UpdateStep(int id, EPackageStatus newStep);
        //Task UpdateProcessStep(int id, EStep newProcessStep);
    }
}
