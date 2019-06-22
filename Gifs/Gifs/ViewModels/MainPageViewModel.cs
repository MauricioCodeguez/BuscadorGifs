using Gifs.Interfaces;
using Gifs.Models;
using Prism.Navigation;
using System;
using System.Threading.Tasks;

namespace Gifs.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IApi _api;

        private Gif _gif = new Gif();
        public Gif Gif
        {
            get { return _gif; }
            set { SetProperty(ref _gif, value); }
        }

        public MainPageViewModel(INavigationService navigationService,
            IApi api)
            : base(navigationService)
        {
            Title = "Top 10 Trending";

            _api = api;
        }

        public async override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.GetNavigationMode() == NavigationMode.New)
                await GetTrending();
        }

        private async Task GetTrending()
        {
            try
            {
                var retorno = await _api.GetTrendingAsync("CYRh1lH68p3cMsrXqd6TYYU1YufBEwh3", 10);

                if (retorno != null)
                    Gif = retorno;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                throw;
            }
        }
    }
}