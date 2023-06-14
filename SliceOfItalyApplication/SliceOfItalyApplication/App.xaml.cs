using SliceOfItalyApplication.Services;
using SliceOfItalyApplication.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SliceOfItalyApplication
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<AddressDataStore>();
            DependencyService.Register<CategoryDataStore>();
            DependencyService.Register<CustomerDataStore>();
            DependencyService.Register<DishDataStore>();
            DependencyService.Register<OrderDataStore>();
            DependencyService.Register<OrderDishDataStore>();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
