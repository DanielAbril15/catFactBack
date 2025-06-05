using BackendGodoy.Models;
using System.Text.Json;

namespace BackendGodoy.Repository
{
    public class GifRepository:IGifRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;
        public GifRepository(
            IHttpClientFactory httpClientFactory,
            IConfiguration config) 
        {
            _httpClient = httpClientFactory.CreateClient();
            _apiUrl = config["Apis:Giphy"]!;
        }

        public async Task<object> GetGifAsync(string words)
        {
            var json = await _httpClient.GetStringAsync($"{_apiUrl}&q={words}");
            var gif = JsonSerializer.Deserialize<object>(json);
            return gif!;
        }
    }
}
