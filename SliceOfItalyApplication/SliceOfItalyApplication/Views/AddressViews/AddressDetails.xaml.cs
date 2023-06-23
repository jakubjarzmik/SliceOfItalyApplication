using SliceOfItalyApplication.ViewModels.AddressViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.AddressViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddressDetails : ContentPage
    {
        public AddressDetails()
        {
            InitializeComponent();
            BindingContext = new AddressDetailsViewModel();
        }
    }
}