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
    public partial class PrayerCenterPage : ContentPage
    {
        
        public PrayerCenterPage()
        {
            InitializeComponent();

            
        }

        private async void Centerbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowCenterPage());
        }

        
    }
}