using BackendGodoy.Models;
using BackendGodoy.Repository;

namespace BackendGodoy.Services
{
    public class FactService
    {
        private readonly IFactRepository _factRepo;

        public FactService(IFactRepository factRepo)
        {
            _factRepo = factRepo;
        }

        public async Task<CatFact> GetRandomFactAsync()
        {
            return await _factRepo.GetFactAsync();
        }
    }
}
