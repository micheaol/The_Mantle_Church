using System;
using The_Mantle_Church.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace The_Mantle_Church
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
