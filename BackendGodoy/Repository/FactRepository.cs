using BackendGodoy.Models;
using System.Text.Json;

namespace BackendGodoy.Repository
{
    public class FactRepository:IFactRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public FactRepository(
            IHttpClientFactory httpClientFactory,
            IConfiguration config)
        {
            _httpClient = httpClientFactory.CreateClient();
            _apiUrl = config["Apis:CatFact"]!;
        }

        public async Task<CatFact> GetFactAsync()
        {
            var json = await _httpClient.GetStringAsync(_apiUrl);
            var fact = JsonSerializer.Deserialize<CatFact>(json);
            return fact!;
        }
    }
}
