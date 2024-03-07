using TARS_Delivery.Models.DTOs.req.HistoryLog;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Models.Enums;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp
{
    public class HistoryLogService : IHistoryLogService
    {
        private readonly IHistoryLogRepository _historyLogRepository;

        public HistoryLogService(IHistoryLogRepository historyLogRepository)
        {
            _historyLogRepository = historyLogRepository;
        }

        public async Task<IEnumerable<HistoryLog>> GetAllHistoryLogs()
        {
            return await _historyLogRepository.GetAllHistoryLogs();
        }

        public async Task<HistoryLog> GetHistoryLogById(int id)
        {
            return await _historyLogRepository.GetHistoryLogById(id);
        }

        public async Task<bool> AddHistoryLog(HistoryLog historyLog)
        {
            return await _historyLogRepository.AddHistoryLog(historyLog);
        }

        public async Task<HistoryLog> UpdateHistoryLog(int id, ListHistoryLogDTO historyLog)
        {
            return await _historyLogRepository.UpdateHistoryLog(id, historyLog);
        }

        public void ChangeStatusHistoryLog(int id, int status)
        {
            _historyLogRepository.ChangeStatusHistoryLog(id, status);
        }

        /*public async Task UpdateStep(int id, EPackageStatus newStep)
        {
            await _historyLogRepository.UpdateStep(id, newStep);
        }*/

        /*public async Task UpdateProcessStep(int id, EStep newProcessStep)
        {
            await _historyLogRepository.UpdateProcessStep(id, newProcessStep);
        }*/
    }
}
