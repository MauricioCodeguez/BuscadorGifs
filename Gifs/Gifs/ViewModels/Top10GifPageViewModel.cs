using Gifs.Interfaces;
using Gifs.Models;
using Prism;
using Prism.AppModel;
using Prism.Navigation;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Gifs.ViewModels
{
    public class Top10GifPageViewModel : ViewModelBase, IPageLifecycleAware
    {
        private readonly IApi _api;

        private Gif _gif = new Gif();
        public Gif Gif
        {
            get { return _gif; }
            set { SetProperty(ref _gif, value); }
        }

        public Top10GifPageViewModel(INavigationService navigationService,
            IApi api) :
            base(navigationService)
        {
            Title = "GIFs";
            _api = api;
        }

        private async Task GetTrending()
        {
            try
            {
                IsBusy = true;

                var retorno = await _api.GetTrendingAsync("CYRh1lH68p3cMsrXqd6TYYU1YufBEwh3", 10);

                if (retorno.Meta.Status == (int)HttpStatusCode.OK)
                {
                    if (retorno.Data.Count > 0)
                        Gif = retorno;
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }

        public async void OnAppearing()
        {
            if (Gif.Data == null)
                await GetTrending();
        }

        public void OnDisappearing()
        {

        }
    }
}