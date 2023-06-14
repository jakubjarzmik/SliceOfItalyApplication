using System.Linq;
using System.Threading.Tasks;
using SliceOfItalyApplication.Helpers;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.Services.Abstract;

namespace SliceOfItalyApplication.Services
{
    public class DishDataStore : AListDataStore<Dish>
    {
        public DishDataStore() : base()
        {

        }

        public override async Task<Dish> AddItemToService(Dish item)
        {
            return await Service.DishesPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(Dish item)
        {
            return await Service.DishesDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<Dish> Find(Dish item)
        {
            return await Service.DishesGETAsync(item.Id);
        }

        public override async Task<Dish> Find(int id)
        {
            return await Service.DishesGETAsync(id);
        }

        public override async Task RefreshListFromService()
        {
            Items = (await Service.DishesAllAsync()).ToList();
        }

        public override async Task<bool> UpdateItemInService(Dish item)
        {
            return await Service.DishesPUTAsync(item.Id, item).HandleRequest();
        }
    }
}
