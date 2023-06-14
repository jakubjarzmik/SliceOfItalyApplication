using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.CategoryViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.CategoryViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewCategoryPage : ContentPage
    {
        public Category Item { get; set; }
        public NewCategoryPage()
        {
            InitializeComponent();
            BindingContext = new NewCategoryViewModel();
        }
    }
}