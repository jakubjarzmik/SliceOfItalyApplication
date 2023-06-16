using SliceOfItalyApplication.ViewModels.DishViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.DishViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DishPage : ContentPage
    {
        private readonly DishViewModel _viewModel;

        public DishPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new DishViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}