using System.Linq;
using Xamarin.Forms;

namespace SliceOfItalyApplication.Helpers
{
    public class ColorTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate AlternateTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var itemsListView = (CollectionView)container;
            var index = itemsListView.ItemsSource.Cast<object>().ToList().IndexOf(item);

            return index % 2 == 0 ? DefaultTemplate : AlternateTemplate;
        }
    }
}
