using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.Abstract;
using SliceOfItalyApplication.Views.CustomerViews;
using Xamarin.Forms;

namespace SliceOfItalyApplication.ViewModels.CustomerViewModels
{
    public class CustomerViewModel : AListViewModel<Customer>
    {
        public CustomerViewModel()
            : base("Customers")
        {

        }
        public override async void GoToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(NewCustomerPage));
        }

        public override async void OnItemSelected(Customer item)
        {
            if (item == null)
                return;

            await Shell.Current.GoToAsync($"{nameof(CustomerDetails)}?{nameof(CustomerDetailsViewModel.ItemId)}={item.Id}");
        }
    }
}
