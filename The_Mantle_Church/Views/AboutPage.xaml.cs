using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace The_Mantle_Church.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;
        }

        private async void PrayerCenter_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrayerCenterPage());
        }

        private async void Event_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventsPage());
        }

        private async void Devotional_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EventsPage());
        }
    }
}