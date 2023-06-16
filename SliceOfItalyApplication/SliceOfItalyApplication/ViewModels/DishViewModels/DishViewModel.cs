using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.Abstract;
using SliceOfItalyApplication.Views.DishViews;
using Xamarin.Forms;

namespace SliceOfItalyApplication.ViewModels.DishViewModels
{
    public class DishViewModel : AListViewModel<DishForView>
    {
        public DishViewModel()
            : base("Dishes")
        {

        }
        public override async void GoToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(NewDishPage));
        }

        public override async void OnItemSelected(DishForView item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(DishDetails)}?{nameof(DishDetailsViewModel.ItemId)}={item.Id}");
        }
    }
}
