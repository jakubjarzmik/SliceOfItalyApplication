using System;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.Abstract;

namespace SliceOfItalyApplication.ViewModels.CustomerViewModels
{
    public class CustomerDetailsViewModel : AItemDetailsViewModel<Customer>
    {
        private string _name;
        private string _email;
        private string _phone;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        public int Id { get; set; }

        public CustomerDetailsViewModel() : base()
        {
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public string Phone
        {
            get => _phone;
            set => SetProperty(ref _phone, value);
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
        public override void LoadProperties(Customer item)
        {
            Id = item.Id;
            Name = item.Name;
            Email = item.Email;
            Phone = item.Phone;
            ModifiedAt = item.ModifiedAt?.DateTime ?? DateTime.Now;
            CreatedAt = item.CreatedAt.DateTime;
        }
    }
}
