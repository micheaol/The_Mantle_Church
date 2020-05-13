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
    public partial class GivePage : ContentPage
    {
        /// <summary>
        /// Bindable property for <see cref="IsLoading" />.
        /// </summary>
        public static readonly BindableProperty IsLoadingProperty = BindableProperty.Create(
            nameof(IsLoading),
            typeof(bool),
            typeof(GivePage),
            defaultValue: true);
        public GivePage()
        {
            InitializeComponent();
            BindingContext = this;

        }
        /// <summary>
        /// Gets or sets a value indicating whether the web viewer is loading.
        /// </summary>
        public bool IsLoading
        {
            get => (bool)GetValue(IsLoadingProperty);
            set => SetValue(IsLoadingProperty, value);
        }

        private void OnWebViewNavigated(object sender, EventArgs eventArgs)
        {
            IsLoading = false;
        }


    }
}