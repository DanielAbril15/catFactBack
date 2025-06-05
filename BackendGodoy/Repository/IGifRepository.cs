using BackendGodoy.Models;

namespace BackendGodoy.Repository
{
    public interface IGifRepository
    {
        Task<object> GetGifAsync(string words);
    }
}
