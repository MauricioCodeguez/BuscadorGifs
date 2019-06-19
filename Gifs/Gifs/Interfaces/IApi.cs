using Gifs.Models;
using Refit;
using System.Threading.Tasks;

namespace Gifs.Interfaces
{
    public interface IApi
    {
        [Get("/trending?api_key={apiKey}&limit={limit}&rating=G")]
        Task<Gif> GetTrendingAsync(string apiKey, int limit);
    }
}