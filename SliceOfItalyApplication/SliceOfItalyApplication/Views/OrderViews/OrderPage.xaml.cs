using SliceOfItalyApplication.ViewModels.OrderViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.OrderViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        private readonly OrderViewModel _viewModel;

        public OrderPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new OrderViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}