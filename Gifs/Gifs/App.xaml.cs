using Prism;
using Prism.Ioc;
using Gifs.ViewModels;
using Gifs.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Gifs.Services;
using Gifs.Interfaces;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Gifs
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            DLToolkit.Forms.Controls.FlowListView.Init();

#if DEBUG
            if (!HotReloader.Current.IsRunning)
            {
                var info = HotReloader.Current.Run(this);
                var port = info.SelectedDevicePort;
                var addresses = info.IPAddresses;
            }
#endif

            await NavigationService.NavigateAsync("NavigationPage/Top10TabbedPage?selectedTab=Top10GifPage");
            //await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IApi, ApiService>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<Top10TabbedPage, Top10TabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<Top10GifPage, Top10GifPageViewModel>();
            containerRegistry.RegisterForNavigation<Top10StickerPage, Top10StickerPageViewModel>();
        }
    }
}