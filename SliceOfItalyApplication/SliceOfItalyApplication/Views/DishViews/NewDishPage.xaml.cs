using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.DishViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.DishViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewDishPage : ContentPage
    {
        public Dish Item { get; set; }
        public NewDishPage()
        {
            InitializeComponent();
            BindingContext = new NewDishViewModel();
        }
    }
}