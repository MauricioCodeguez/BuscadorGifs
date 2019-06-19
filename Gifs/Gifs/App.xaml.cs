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

#if DEBUG
            if (!HotReloader.Current.IsRunning)
            {
                HotReloader.Current.Run(this, new HotReloader.Configuration
                {
                    ExtensionAutoDiscoveryPort = 15000
                });
            }
#endif

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IApi, ApiService>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }
    }
}