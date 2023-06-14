using System;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.Abstract;

namespace SliceOfItalyApplication.ViewModels.CustomerViewModels
{
    public class NewCustomerViewModel : ANewViewModel<Customer>
    {
        public NewCustomerViewModel()
            : base()
        {

        }

        #region Fields

        private string _name;
        private string _email;
        private string _phone;
        #endregion

        #region Properties

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

        #endregion

        public override Customer SetItem()
        {
            return new Customer
            {
                Id = 0,
                Name = Name,
                Email = Email,
                Phone = Phone,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                IsActive = true,
                Addresses = null
            };
        }

        public override bool ValidateSave()
        {
            return !string.IsNullOrEmpty(_name);
        }
    }
}
