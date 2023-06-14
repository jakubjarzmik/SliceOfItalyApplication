using SliceOfItalyApplication.ViewModels;
using SliceOfItalyApplication.Views;
using System;
using System.Collections.Generic;
using SliceOfItalyApplication.Views.CategoryViews;
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
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
