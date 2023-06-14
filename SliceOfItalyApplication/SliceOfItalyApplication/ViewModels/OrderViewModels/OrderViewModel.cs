using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.Abstract;
using SliceOfItalyApplication.Views.OrderViews;
using Xamarin.Forms;

namespace SliceOfItalyApplication.ViewModels.OrderViewModels
{
    public class OrderViewModel : AListViewModel<Order>
    {
        public OrderViewModel()
            : base("Orders")
        {

        }
        public override async void GoToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(NewOrderPage));
        }

        public override async void OnItemSelected(Order item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(OrderDetails)}?{nameof(OrderDetailsViewModel.ItemId)}={item.Id}");
        }
    }
}
