using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.OrderViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.OrderViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewOrderPage : ContentPage
    {
        public Order Item { get; set; }
        public NewOrderPage()
        {
            InitializeComponent();
            BindingContext = new NewOrderViewModel();
        }
    }
}