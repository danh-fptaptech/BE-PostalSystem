using AutoMapper;
using TARS_Delivery.Models.DTOs.req.HistoryLog;
using TARS_Delivery.Models.Entities;
using TARS_Delivery.Repositories;

namespace TARS_Delivery.Services.imp
{
    public class HistoryLogService
    {
        private readonly IHistoryLogRepository _historyLogRepository;
        private readonly IMapper _mapper;

        public HistoryLogService(IHistoryLogRepository historyLogRepository, IMapper mapper)
        {
            _historyLogRepository = historyLogRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ListHistoryLogDTO>> GetAllHistoryLogs()
        {
            return await _historyLogRepository.GetAllHistoryLogs();
        }

        public async Task<HistoryLog> GetHistoryLogById(int id)
        {
            return await _historyLogRepository.GetHistoryLogById(id);
        }

        public async Task<HistoryLog> AddHistoryLog(ListHistoryLogDTO historyLog)
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
    }
}
