using SliceOfItalyApplication.ViewModels.CategoryViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.CategoryViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryDetails : ContentPage
    {
        public CategoryDetails()
        {
            InitializeComponent();
            BindingContext = new CategoryDetailsViewModel();
        }
    }
}