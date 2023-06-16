using System;
using System.Collections.Generic;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.Services;
using SliceOfItalyApplication.ViewModels.Abstract;

namespace SliceOfItalyApplication.ViewModels.DishViewModels
{
    public class NewDishViewModel : ANewViewModel<DishForView>
    {
        public NewDishViewModel()
            : base()
        {
            _selectedCategory = new Category();
            var categoryDataStore = new CategoryDataStore();
            categoryDataStore.RefreshListFromService();
            Categories = categoryDataStore.Items;
        }

        #region Fields

        private Category _selectedCategory;
        private string _name;
        private string _description;
        private double _price;

        #endregion

        #region Properties

        public List<Category> Categories { get; }

        public Category SelectedCategory
        {
            get => _selectedCategory;
            set => SetProperty(ref _selectedCategory, value);
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

        #endregion

        public override DishForView SetItem()
        {
            return new DishForView
            {
                Id = 0,
                Name = Name,
                Description = Description,
                Price = Price,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                CategoryId = _selectedCategory.Id,
                CategoryName = _selectedCategory.Name,
                IsActive = true
            };
        }

        public override bool ValidateSave()
        {
            return !(string.IsNullOrEmpty(Name) && double.IsNaN(Price));
        }
    }
}
