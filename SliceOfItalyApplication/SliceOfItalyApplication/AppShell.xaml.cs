using System;
using SliceOfItalyApplication.Views.CategoryViews;
using SliceOfItalyApplication.Views.CustomerViews;
using SliceOfItalyApplication.Views.DishViews;
using SliceOfItalyApplication.Views.OrderDishViews;
using SliceOfItalyApplication.Views.OrderViews;
using Xamarin.Forms;

namespace SliceOfItalyApplication
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NewCategoryPage), typeof(NewCategoryPage));
            Routing.RegisterRoute(nameof(CategoryDetails), typeof(CategoryDetails));
            Routing.RegisterRoute(nameof(NewCustomerPage), typeof(NewCustomerPage));
            Routing.RegisterRoute(nameof(CustomerDetails), typeof(CustomerDetails));
            Routing.RegisterRoute(nameof(NewOrderPage), typeof(NewOrderPage));
            Routing.RegisterRoute(nameof(OrderDetails), typeof(OrderDetails));
            Routing.RegisterRoute(nameof(NewDishPage), typeof(NewDishPage));
            Routing.RegisterRoute(nameof(DishDetails), typeof(DishDetails));
            Routing.RegisterRoute(nameof(NewOrderDishPage), typeof(NewOrderDishPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
