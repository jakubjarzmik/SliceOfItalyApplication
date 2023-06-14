using System;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.Abstract;

namespace SliceOfItalyApplication.ViewModels.CategoryViewModels
{
    public class NewCategoryViewModel : ANewViewModel<Category>
    {
        public NewCategoryViewModel()
            : base()
        {

        }

        #region Fields

        private string _name;
        private string _description;
        #endregion

        #region Properties

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

        #endregion

        public override Category SetItem()
        {
            return new Category
            {
                Id = 0,
                Name = Name,
                Description = Description,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                IsActive = true,
                Dishes = null
            };
        }

        public override bool ValidateSave()
        {
            return !string.IsNullOrEmpty(_name);
        }
    }
}
