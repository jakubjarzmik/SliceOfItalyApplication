using System;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.Abstract;

namespace SliceOfItalyApplication.ViewModels.AddressViewModels
{
    public class AddressDetailsViewModel : AItemDetailsViewModel<AddressForView>
    {
        private string _addressLine1;
        private string _postalCode;
        private string _city;
        private string _customer;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        public int Id { get; set; }

        public AddressDetailsViewModel() : base()
        {
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
        public override void LoadProperties(AddressForView item)
        {
            Id = item.Id;
            AddressLine1 = item.AddressLine1;
            PostalCode = item.PostalCode;
            City = item.City;
            Customer = item.CustomerName;
            ModifiedAt = item.ModifiedAt?.DateTime ?? DateTime.Now;
            CreatedAt = item.CreatedAt.DateTime;
        }
    }
}
