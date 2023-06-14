using System;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.ViewModels.Abstract;

namespace SliceOfItalyApplication.ViewModels.CategoryViewModels
{
    public class CategoryDetailsViewModel : AItemDetailsViewModel<Category>
    {
        private string _name;
        private string _description;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        public int Id { get; set; }

        public CategoryDetailsViewModel() : base()
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
        public override void LoadProperties(Category item)
        {
            Id = item.Id;
            Name = item.Name;
            Description = item.Description;
            ModifiedAt = item.ModifiedAt?.DateTime ?? DateTime.Now;
            CreatedAt = item.CreatedAt.DateTime;
        }
    }
}
