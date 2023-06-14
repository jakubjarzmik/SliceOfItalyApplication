using System.Net.Http;
using SliceOfItalyApplication.Service.Reference;

namespace SliceOfItalyApplication.Services.Abstract
{
    public abstract class ADataStore
    {
        protected SliceOfItalyService Service;

        protected ADataStore()
        {
            var handler = new HttpClientHandler();
#if DEBUG
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) => true;
#endif
            var client = new HttpClient(handler);
            Service = new SliceOfItalyService("https://localhost:7293", client);
        }
    }
}
