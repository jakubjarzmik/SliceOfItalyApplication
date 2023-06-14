using System.Linq;
using System.Threading.Tasks;
using SliceOfItalyApplication.Helpers;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.Services.Abstract;

namespace SliceOfItalyApplication.Services
{
    public class OrderDataStore : AListDataStore<Order>
    {
        public OrderDataStore()
        {

        }

        public override async Task<Order> AddItemToService(Order item)
        {
            return await Service.OrdersPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(Order item)
        {
            return await Service.OrdersDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<Order> Find(Order item)
        {
            return await Service.OrdersGETAsync(item.Id);
        }

        public override async Task<Order> Find(int id)
        {
            return await Service.OrdersGETAsync(id);
        }

        public override async Task RefreshListFromService()
        {
            Items = (await Service.OrdersAllAsync()).ToList();
        }

        public override async Task<bool> UpdateItemInService(Order item)
        {
            return await Service.OrdersPUTAsync(item.Id, item).HandleRequest();
        }
    }
}
