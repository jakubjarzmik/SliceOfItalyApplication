using SliceOfItalyApplication.ViewModels.CustomerViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.CustomerViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomerPage : ContentPage
    {
        private readonly CustomerViewModel _viewModel;

        public CustomerPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new CustomerViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}