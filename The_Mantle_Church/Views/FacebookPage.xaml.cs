using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace The_Mantle_Church.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacebookPage : ContentPage
    {
        /// <summary>
        /// Bindable property for <see cref="IsLoading" />.
        /// </summary>
        public static readonly BindableProperty IsLoadingProperty = BindableProperty.Create(
            nameof(IsLoading),
            typeof(bool),
            typeof(FacebookPage),
            defaultValue: true);

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class. The page uses itself as the
        /// binding context for simplicity. In a bigger project, you'd typically use a view model.
        /// </summary>


        public FacebookPage()
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