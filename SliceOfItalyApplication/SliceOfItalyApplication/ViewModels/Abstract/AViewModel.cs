using Xamarin.Forms;

namespace SliceOfItalyApplication.ViewModels.Abstract
{
    public abstract class AViewModel<T> where T : class
    {
        public T DataStore => DependencyService.Get<T>();
    }
}
