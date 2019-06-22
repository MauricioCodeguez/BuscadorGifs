using Gifs.Interfaces;
using Prism.Navigation;

namespace Gifs.ViewModels
{
    public class Top10TabbedPageViewModel : ViewModelBase
    {
        public Top10TabbedPageViewModel(INavigationService navigationService,
            IApi api) : 
            base(navigationService)
        {
            Title = "Top 10";
        }
    }
}