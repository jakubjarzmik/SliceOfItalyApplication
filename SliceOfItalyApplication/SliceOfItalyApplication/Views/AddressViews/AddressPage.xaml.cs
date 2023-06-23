using SliceOfItalyApplication.ViewModels.AddressViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.AddressViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddressPage : ContentPage
    {
        private readonly AddressViewModel _viewModel;

        public AddressPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new AddressViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}