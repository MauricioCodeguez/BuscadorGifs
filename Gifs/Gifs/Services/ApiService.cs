using Gifs.Interfaces;
using Gifs.Models;
using Refit;
using System.Threading.Tasks;

namespace Gifs.Services
{
    public class ApiService : IApi
    {
        private readonly IApi _api;

        public ApiService()
        {
            _api = RestService.For<IApi>("https://api.giphy.com/v1");
        }

        public async Task<Gif> GetTrendingAsync(string apiKey, int limit) =>
            await _api.GetTrendingAsync(apiKey, limit);

        public async Task<Gif> GetTrendingStickerAsync(string apiKey, int limit) =>
            await _api.GetTrendingStickerAsync(apiKey, limit);
    }
}