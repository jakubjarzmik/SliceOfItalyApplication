using System;
using System.Collections.Generic;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.Services;
using SliceOfItalyApplication.ViewModels.Abstract;

namespace SliceOfItalyApplication.ViewModels.AddressViewModels
{
    public class NewAddressViewModel : ANewViewModel<AddressForView>
    {
        public NewAddressViewModel()
            : base()
        {
            _selectedCustomer = new Customer();
            var customerDataStore = new CustomerDataStore();
            customerDataStore.RefreshListFromService();
            Customers = customerDataStore.Items;
        }

        #region Fields

        private Customer _selectedCustomer;
        private string _addressLine1;
        private string _postalCode;
        private string _city;

        #endregion

        #region Properties

        public List<Customer> Customers { get; }

        public Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set => SetProperty(ref _selectedCustomer, value);
        }
        public string AddressLine1
        {
            get => _addressLine1;
            set => SetProperty(ref _addressLine1, value);
        }
        public string PostalCode
        {
            get => _postalCode;
            set => SetProperty(ref _postalCode, value);
        }
        public string City
        {
            get => _city;
            set => SetProperty(ref _city, value);
        }

        #endregion

        public override AddressForView SetItem()
        {
            return new AddressForView
            {
                Id = 0,
                AddressLine1 = AddressLine1,
                PostalCode = PostalCode,
                City = City,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                CustomerId = _selectedCustomer.Id,
                CustomerName = _selectedCustomer.Name,
                IsActive = true
            };
        }

        public override bool ValidateSave()
        {
            return !(string.IsNullOrEmpty(AddressLine1) && string.IsNullOrEmpty(PostalCode) && string.IsNullOrEmpty(City));
        }
    }
}
