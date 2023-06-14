using SliceOfItalyApplication.ViewModels.CustomerViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.CustomerViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomerDetails : ContentPage
    {
        public CustomerDetails()
        {
            InitializeComponent();
            BindingContext = new CustomerDetailsViewModel();
        }
    }
}