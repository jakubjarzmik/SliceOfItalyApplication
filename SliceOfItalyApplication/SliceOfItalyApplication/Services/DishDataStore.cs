using System.Linq;
using System.Threading.Tasks;
using SliceOfItalyApplication.Helpers;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.Services.Abstract;

namespace SliceOfItalyApplication.Services
{
    public class DishDataStore : AListDataStore<DishForView>
    {
        public DishDataStore() : base()
        {

        }

        public override async Task<DishForView> AddItemToService(DishForView item)
        {
            return await Service.DishesPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(DishForView item)
        {
            return await Service.DishesDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<DishForView> Find(DishForView item)
        {
            return await Service.DishesGETAsync(item.Id);
        }

        public override async Task<DishForView> Find(int id)
        {
            return await Service.DishesGETAsync(id);
        }

        public override  Task RefreshListFromService()
        {
            Items = Service.DishesAllAsync().Result.ToList();
            return Task.CompletedTask;
        }

        public override async Task<bool> UpdateItemInService(DishForView item)
        {
            return await Service.DishesPUTAsync(item.Id, item).HandleRequest();
        }
    }
}
