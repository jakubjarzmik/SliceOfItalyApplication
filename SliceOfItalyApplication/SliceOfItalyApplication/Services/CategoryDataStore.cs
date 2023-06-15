using System.Linq;
using System.Threading.Tasks;
using SliceOfItalyApplication.Helpers;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.Services.Abstract;

namespace SliceOfItalyApplication.Services
{
    public class CategoryDataStore : AListDataStore<Category>
    {
        public CategoryDataStore() : base()
        {
            
        }

        public override async Task<Category> AddItemToService(Category item)
        {
            return await Service.CategoriesPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(Category item)
        {
            return await Service.CategoriesDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<Category> Find(Category item)
        {
            return await Service.CategoriesGETAsync(item.Id);
        }

        public override async Task<Category> Find(int id)
        {
            return await Service.CategoriesGETAsync(id);
        }

        public override Task RefreshListFromService()
        {
            Items = Service.CategoriesAllAsync().Result.ToList();
            return Task.CompletedTask;
        }

        public override async Task<bool> UpdateItemInService(Category item)
        {
            return await Service.CategoriesPUTAsync(item.Id, item).HandleRequest();
        }
    }
}
