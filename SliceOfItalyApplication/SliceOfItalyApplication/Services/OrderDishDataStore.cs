using System.Linq;
using System.Threading.Tasks;
using SliceOfItalyApplication.Helpers;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.Services.Abstract;

namespace SliceOfItalyApplication.Services
{
    public class OrderDishDataStore : AListDataStore<OrderDishForView>
    {
        public OrderDishDataStore() : base()
        {

        }

        public override async Task<OrderDishForView> AddItemToService(OrderDishForView item)
        {
            return await Service.OrderDishesPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(OrderDishForView item)
        {
            return await Service.OrderDishesDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<OrderDishForView> Find(OrderDishForView item)
        {
            return await Service.OrderDishesGETAsync(item.Id);
        }

        public override async Task<OrderDishForView> Find(int id)
        {
            return await Service.OrderDishesGETAsync(id);
        }

        public override Task RefreshListFromService()
        {
            Items = Service.OrderDishesAllAsync().Result.ToList();
            return Task.CompletedTask;
        }

        public override async Task<bool> UpdateItemInService(OrderDishForView item)
        {
            return await Service.OrderDishesPUTAsync(item.Id, item).HandleRequest();
        }
    }
}
