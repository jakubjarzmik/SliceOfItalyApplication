using System.Linq;
using System.Threading.Tasks;
using SliceOfItalyApplication.Helpers;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.Services.Abstract;

namespace SliceOfItalyApplication.Services
{
    public class OrderDataStore : AListDataStore<OrderForView>
    {
        public OrderDataStore()
        {

        }

        public override async Task<OrderForView> AddItemToService(OrderForView item)
        {
            return await Service.OrdersPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(OrderForView item)
        {
            return await Service.OrdersDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<OrderForView> Find(OrderForView item)
        {
            return await Service.OrdersGETAsync(item.Id);
        }

        public override async Task<OrderForView> Find(int id)
        {
            return await Service.OrdersGETAsync(id);
        }

        public override Task RefreshListFromService()
        {
            Items = Service.OrdersAllAsync().Result.ToList();
            return Task.CompletedTask;
        }

        public override async Task<bool> UpdateItemInService(OrderForView item)
        {
            return await Service.OrdersPUTAsync(item.Id, item).HandleRequest();
        }
    }
}
