using System.Linq;
using System.Threading.Tasks;
using SliceOfItalyApplication.Helpers;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.Services.Abstract;

namespace SliceOfItalyApplication.Services
{
    public class OrderDishDataStore : AListDataStore<OrderDish>
    {
        public OrderDishDataStore() : base()
        {

        }

        public override async Task<OrderDish> AddItemToService(OrderDish item)
        {
            return await Service.OrderDishesPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(OrderDish item)
        {
            return await Service.OrderDishesDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<OrderDish> Find(OrderDish item)
        {
            return await Service.OrderDishesGETAsync(item.Id);
        }

        public override async Task<OrderDish> Find(int id)
        {
            return await Service.OrderDishesGETAsync(id);
        }

        public override async Task RefreshListFromService()
        {
            Items = (await Service.OrderDishesAllAsync()).ToList();
        }

        public override async Task<bool> UpdateItemInService(OrderDish item)
        {
            return await Service.OrderDishesPUTAsync(item.Id, item).HandleRequest();
        }
    }
}
