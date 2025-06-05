using BackendGodoy.DTOs;
using BackendGodoy.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendGodoy.Repository
{
    public class HistoryRepository : IHistoryDataRepository
    {
        private CatFactsContext _context;
        public HistoryRepository(CatFactsContext context ) 
        {
            _context = context;
        }
        public async Task<IEnumerable<History>> GetHistoryAsync()=>
            await _context.Histories.ToListAsync();
        public async Task PostHistoryAsync(History history)=>
            await _context.Histories.AddAsync(history);
        public async Task Save() =>
          await _context.SaveChangesAsync();

    }
}
