using BackendGodoy.DTOs;
using BackendGodoy.Models;

namespace BackendGodoy.Repository
{
    public interface IHistoryDataRepository
    {
        
        Task<IEnumerable<History>> GetHistoryAsync();
        Task PostHistoryAsync(History history);
        Task Save();
    }
}
