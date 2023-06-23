using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.Abstract;
using SliceOfItalyApplication.Views.CategoryViews;
using Xamarin.Forms;

namespace SliceOfItalyApplication.ViewModels.CategoryViewModels
{
    public class CategoryViewModel : AListViewModel<Category>
    {
        public CategoryViewModel()
            : base("Categories")
        {

        }
        public override async void GoToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(NewCategoryPage));
        }

        public override async void OnItemSelected(Category item)
        {
            if (item == null)
                return;

            await Shell.Current.GoToAsync($"{nameof(CategoryDetails)}?{nameof(CategoryDetailsViewModel.ItemId)}={item.Id}");
        }
    }
}
