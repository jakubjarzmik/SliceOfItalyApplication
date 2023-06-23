using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.Abstract;
using SliceOfItalyApplication.Views.AddressViews;
using Xamarin.Forms;

namespace SliceOfItalyApplication.ViewModels.AddressViewModels
{
    public class AddressViewModel : AListViewModel<AddressForView>
    {
        public AddressViewModel()
            : base("Addresses")
        {

        }
        public override async void GoToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(NewAddressPage));
        }

        public override async void OnItemSelected(AddressForView item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(AddressDetails)}?{nameof(AddressDetailsViewModel.ItemId)}={item.Id}");
        }
    }
}
