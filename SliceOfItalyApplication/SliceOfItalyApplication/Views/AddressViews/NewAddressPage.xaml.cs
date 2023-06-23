using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.AddressViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.AddressViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewAddressPage : ContentPage
    {
        public Address Item { get; set; }
        public NewAddressPage()
        {
            InitializeComponent();
            BindingContext = new NewAddressViewModel();
        }
    }
}