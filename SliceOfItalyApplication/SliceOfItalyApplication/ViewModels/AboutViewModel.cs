using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SliceOfItalyApplication.ViewModels
{
    public class AboutViewModel : BaseViewModel
{
    public AboutViewModel()
    {
        Title = "About";
        OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        GoToOrdersPageCommand = new Command(async () => await Shell.Current.GoToAsync("//OrderPage"));
        GoToCustomersPageCommand = new Command(async () => await Shell.Current.GoToAsync("//CustomerPage"));
        GoToDishesPageCommand = new Command(async () => await Shell.Current.GoToAsync("//DishPage"));
    }

    public ICommand OpenWebCommand { get; }
    public ICommand GoToOrdersPageCommand { get; }
    public ICommand GoToCustomersPageCommand { get; }
    public ICommand GoToDishesPageCommand { get; }
}

}