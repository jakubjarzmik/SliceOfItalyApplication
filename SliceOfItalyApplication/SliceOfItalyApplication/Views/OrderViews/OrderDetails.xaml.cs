using SliceOfItalyApplication.ViewModels.OrderViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.OrderViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderDetails : ContentPage
    {
        public OrderDetails()
        {
            InitializeComponent();
            BindingContext = new OrderDetailsViewModel();
        }
    }
}