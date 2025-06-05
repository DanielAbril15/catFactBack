using BackendGodoy.DTOs;
using BackendGodoy.Models;
using BackendGodoy.Repository;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendGodoy.Services
{
    public class HistoryService
    {
        private IHistoryDataRepository _historyRepo;
        public HistoryService(IHistoryDataRepository historyRepo)
        {
            _historyRepo = historyRepo;
        }

        public async Task<IEnumerable<History>> GetHistories()
        {
            var histories = await _historyRepo.GetHistoryAsync();
            return histories;
        }

        public async Task<HistoryDto> AddHistory(HistoryInsertDto historyInsertDto) 
        {
            var historyData = new History
            {
                date= DateTime.UtcNow,
                cat_fact = historyInsertDto.cat_fact,
                words = historyInsertDto.words,
                gif_url = historyInsertDto.gif_url
            };
            await _historyRepo.PostHistoryAsync(historyData);
            await _historyRepo.Save();

            var historyDto = new HistoryDto
            {
                Id = historyData.Id,
                cat_fact= historyData.cat_fact,
                date = historyData.date,
                words = historyData.words,
                gif_url= historyData.gif_url
            };

            return historyDto;
        }
    }
}
