using BackendGodoy.Models;

namespace BackendGodoy.Repository
{
    public interface IFactRepository
    {
        Task<CatFact> GetFactAsync();
    }
}
