using System;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.Abstract;

namespace SliceOfItalyApplication.ViewModels.DishViewModels
{
    public class DishDetailsViewModel : AItemDetailsViewModel<DishForView>
    {
        private string _name;
        private string _description;
        private double _price;
        private string _category;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        public int Id { get; set; }

        public DishDetailsViewModel() : base()
        {
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }
        public double Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }

        public string Category
        {
            get => _category;
            set => SetProperty(ref _category, value);
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
        public override void LoadProperties(DishForView item)
        {
            Id = item.Id;
            Name = item.Name;
            Description = item.Description;
            Price = item.Price;
            Category = item.CategoryName;
            ModifiedAt = item.ModifiedAt?.DateTime ?? DateTime.Now;
            CreatedAt = item.CreatedAt.DateTime;
        }
    }
}
