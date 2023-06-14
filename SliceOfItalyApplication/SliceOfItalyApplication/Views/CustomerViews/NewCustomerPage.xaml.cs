using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.CustomerViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication.Views.CustomerViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewCustomerPage : ContentPage
    {
        public Customer Item { get; set; }
        public NewCustomerPage()
        {
            InitializeComponent();
            BindingContext = new NewCustomerViewModel();
        }
    }
}