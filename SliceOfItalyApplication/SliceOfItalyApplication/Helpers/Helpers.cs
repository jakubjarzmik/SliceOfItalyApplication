using System;
using System.Threading.Tasks;

namespace SliceOfItalyApplication.Helpers
{
    public static class Helpers
    {
        public static async Task<bool> HandleRequest(this Task serviceMethod)
        {
            try
            {
                await serviceMethod;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}