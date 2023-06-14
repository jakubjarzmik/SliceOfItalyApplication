using System.Linq;
using System.Threading.Tasks;
using SliceOfItalyApplication.Helpers;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.Services.Abstract;

namespace SliceOfItalyApplication.Services
{
    public class CustomerDataStore : AListDataStore<Customer>
    {
        public CustomerDataStore() : base()
        {

        }

        public override async Task<Customer> AddItemToService(Customer item)
        {
            return await Service.CustomersPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(Customer item)
        {
            return await Service.CustomersDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<Customer> Find(Customer item)
        {
            return await Service.CustomersGETAsync(item.Id);
        }

        public override async Task<Customer> Find(int id)
        {
            return await Service.CustomersGETAsync(id);
        }

        public override Task RefreshListFromService()
        {
            Items = Service.CustomersAllAsync().Result.ToList();
            return Task.CompletedTask;
        }

        public override async Task<bool> UpdateItemInService(Customer item)
        {
            return await Service.CustomersPUTAsync(item.Id, item).HandleRequest();
        }
    }
}
