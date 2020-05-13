using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Mantle_Church.Helpers;
using The_Mantle_Church.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace The_Mantle_Church.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MantleRegPage : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        
        public MantleRegPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allPersons = await firebaseHelper.GetAllPersons();
            //lstPersons.ItemsSource = allPersons;
        }

        //private async void btnadd_clicked(object sender, eventargs e)
        //{
        //    await firebasehelper.addperson(convert.toint32(txtid.text), txtname.text, txtphone.text, txtlocation.text, txtdepart.text);
        //    txtid.text = string.empty;
        //    txtname.text = string.empty;
        //    txtdepart.text = string.empty;
        //    txtlocation.text = string.empty;
        //    txtphone.text = string.empty;

        //    await displayalert("success", "person added successfully", "ok");
        //    var allpersons = await firebasehelper.getallpersons();
        //    lstpersons.itemssource = allpersons;
        //}

        private async void BtnRegister_Clicked(object sender, EventArgs e)
        {
         

            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtDepart.Text) && !string.IsNullOrEmpty(txtLocation.Text) && !string.IsNullOrEmpty(txtPhone.Text) /*&& !string.IsNullOrEmpty(txtId.Text)*/)
            {
                await firebaseHelper.AddPerson(Convert.ToInt32(txtId.Text), txtName.Text, txtPhone.Text, txtLocation.Text, txtDepart.Text);
                txtId.Text = string.Empty;
                txtName.Text = string.Empty;
                txtDepart.Text = string.Empty;
                txtLocation.Text = string.Empty;
                txtPhone.Text = string.Empty;

                await DisplayAlert("Success", "Registration Successfully", "OK");
                var allPersons = await firebaseHelper.GetAllPersons();
                //lstPersons.ItemsSource = allPersons;

            }
            else
            {
                await DisplayAlert("Error", "Please fill all field", "OK");
            }

        }
    }
}