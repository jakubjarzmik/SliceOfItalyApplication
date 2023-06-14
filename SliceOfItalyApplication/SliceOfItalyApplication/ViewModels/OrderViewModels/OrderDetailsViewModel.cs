using System;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.Abstract;

namespace SliceOfItalyApplication.ViewModels.OrderViewModels
{
    public class OrderDetailsViewModel : AItemDetailsViewModel<Order>
    {
        private double _totalPrice;
        private DateTime _orderDate;
        private string _customer;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        public int Id { get; set; }

        public OrderDetailsViewModel() : base()
        {
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
        public override void LoadProperties(Order item)
        {
            Id = item.Id;
            TotalPrice = item.TotalPrice;
            OrderDate = item.OrderDate.DateTime;
            Customer = item.Customer.Name;
            ModifiedAt = item.ModifiedAt?.DateTime ?? DateTime.Now;
            CreatedAt = item.CreatedAt.DateTime;
        }
    }
}
