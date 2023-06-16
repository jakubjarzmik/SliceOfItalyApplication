using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.OrderDishViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.OrderDishViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewOrderDishPage : ContentPage
    {
        public OrderDishForView Item { get; set; }
        public NewOrderDishPage()
        {
            InitializeComponent();
            BindingContext = new NewOrderDishViewModel();
        }
    }
}