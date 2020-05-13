using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using The_Mantle_Church.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace The_Mantle_Church
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        Dictionary<string, Type> routes = new Dictionary<string, Type>();


        public ICommand NavigateCommand => new Command(Navigate);
        public ICommand SettingsCommand => new Command (async () => await PushPage(new MantleRegPage()));

        private async Task PushPage(Page page)
        {
            await Shell.Current.Navigation.PushAsync(page);
            Shell.Current.FlyoutIsPresented = false;
        }

        private async void Navigate(object route)
        {
            ShellNavigationState state = Shell.Current.CurrentState;
            await Shell.Current.GoToAsync($"{state.Location}/{route.ToString()}");
            Shell.Current.FlyoutIsPresented = false;
        }

        void RegisterRoutes()
        {
            routes.Add("About", typeof(AboutPage));
            routes.Add("Give", typeof(GivePage));
            routes.Add("TheMantleTV", typeof(TheMantleTV));
            routes.Add("mantlecourse", typeof(MantleRegPage));
            routes.Add("prayercenter", typeof(PrayerCenterPage));
            routes.Add("FacebookPage", typeof(FacebookPage));
            


            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}