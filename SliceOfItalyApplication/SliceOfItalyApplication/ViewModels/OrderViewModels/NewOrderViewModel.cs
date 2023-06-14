﻿using System;
using System.Collections.Generic;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.Services;
using SliceOfItalyApplication.ViewModels.Abstract;

namespace SliceOfItalyApplication.ViewModels.OrderViewModels
{
    public class NewOrderViewModel : ANewViewModel<Order>
    {
        public NewOrderViewModel()
            : base()
        {
            _selectedCustomer = new Customer();
            var customerDataStore = new CustomerDataStore();
            customerDataStore.RefreshListFromService();
            _customers = customerDataStore.Items;
        }

        #region Fields

        private Customer _selectedCustomer;
        private double _totalPrice;
        private DateTime _orderDate = DateTime.Now;
        private List<Customer> _customers;

        #endregion

        #region Properties

        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
        }

        public Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set => SetProperty(ref _selectedCustomer, value);
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

        #endregion

        public override Order SetItem()
        {
            return new Order
            {
                Id = 0,
                TotalPrice = TotalPrice,
                OrderDate = OrderDate,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                CustomerId = _selectedCustomer.Id,
                IsActive = true,
                OrderDishes = null
            };
        }

        public override bool ValidateSave()
        {
            return !double.IsNaN(_totalPrice);
        }
    }
}