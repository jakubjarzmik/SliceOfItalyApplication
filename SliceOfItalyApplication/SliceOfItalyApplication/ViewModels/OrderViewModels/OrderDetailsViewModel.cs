using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.Abstract;
using SliceOfItalyApplication.ViewModels.OrderDishViewModels;
using SliceOfItalyApplication.Views.OrderDishViews;
using Xamarin.Forms;

namespace SliceOfItalyApplication.ViewModels.OrderViewModels
{
    public class OrderDetailsViewModel : AItemDetailsViewModel<OrderForView>
    {
        private int _id;
        private double _totalPrice;
        private DateTime _orderDate;
        private string _customer;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        private OrderForView _detailedItem;

        public OrderDetailsViewModel() : base()
        {
            Items = new ObservableCollection<OrderDishForView>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            AddDishCommand = new Command(async () => await Shell.Current.GoToAsync($"{nameof(NewOrderDishPage)}?{nameof(NewOrderDishViewModel.ItemId)}={Id}"));
        }

        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }
        public double TotalPrice
        {
            get => _totalPrice;
            set => SetProperty(ref _totalPrice, value);
        }
        public DateTime OrderDate
        {
            get => _orderDate;
            set => SetProperty(ref _orderDate, value);
        }

        public string Customer
        {
            get => _customer;
            set => SetProperty(ref _customer, value);
        }
        public DateTime CreatedAt
        {
            get => _createdAt;
            set => SetProperty(ref _createdAt, value);
        }
        public DateTime ModifiedAt
        {
            get => _modifiedAt;
            set => SetProperty(ref _modifiedAt, value);
        }
        public ObservableCollection<OrderDishForView> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddDishCommand { get; }
        public override async void LoadProperties(OrderForView item)
        {
            Id = item.Id;
            TotalPrice = item.TotalPrice;
            OrderDate = item.OrderDate.DateTime;
            Customer = item.CustomerName;
            ModifiedAt = item.ModifiedAt?.DateTime ?? DateTime.Now;
            CreatedAt = item.CreatedAt.DateTime;
            _detailedItem = item;
            await ExecuteLoadItemsCommand();
        }
        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;
            try
            {
                Items.Clear();
                var items = _detailedItem.OrderDishes;
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
