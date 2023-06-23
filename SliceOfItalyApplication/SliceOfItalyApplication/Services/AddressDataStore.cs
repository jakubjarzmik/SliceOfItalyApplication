using System.Linq;
using System.Threading.Tasks;
using SliceOfItalyApplication.Helpers;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.Services.Abstract;

namespace SliceOfItalyApplication.Services
{
    public class AddressDataStore : AListDataStore<AddressForView>
    {
        public AddressDataStore() : base()
        {
            
        }

        public override async Task<AddressForView> AddItemToService(AddressForView item)
        {
            return await Service.AddressesPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(AddressForView item)
        {
            return await Service.AddressesDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<AddressForView> Find(AddressForView item)
        {
            return await Service.AddressesGETAsync(item.Id);
        }

        public override async Task<AddressForView> Find(int id)
        {
            return await Service.AddressesGETAsync(id);
        }

        public override Task RefreshListFromService()
        {
            Items = Service.AddressesAllAsync().Result.ToList();
            return Task.CompletedTask;
        }

        public override async Task<bool> UpdateItemInService(AddressForView item)
        {
            return await Service.AddressesPUTAsync(item.Id, item).HandleRequest();
        }
    }
}
