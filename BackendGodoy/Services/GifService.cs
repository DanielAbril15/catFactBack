using BackendGodoy.Repository;

namespace BackendGodoy.Services
{
    public class GifService
    {
        private readonly IGifRepository _gifrepo;
        public GifService(IGifRepository gifRepo)
        {
            _gifrepo = gifRepo;
        }

        public async Task<object> GetGif(string words)
        {

            return await _gifrepo.GetGifAsync(words);

        }
    }
}
