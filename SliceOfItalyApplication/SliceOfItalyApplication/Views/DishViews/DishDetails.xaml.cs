using SliceOfItalyApplication.ViewModels.DishViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.DishViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DishDetails : ContentPage
    {
        public DishDetails()
        {
            InitializeComponent();
            BindingContext = new DishDetailsViewModel();
        }
    }
}