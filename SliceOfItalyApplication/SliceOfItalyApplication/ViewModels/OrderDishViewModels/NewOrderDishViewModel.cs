using SliceOfItalyApplication.ViewModels.Abstract;
using System.Collections.Generic;
using System;
using SliceOfItalyApplication.Helpers;
using SliceOfItalyApplication.Service.Reference;
using SliceOfItalyApplication.Services;
using Xamarin.Forms;

namespace SliceOfItalyApplication.ViewModels.OrderDishViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class NewOrderDishViewModel : ANewViewModel<OrderDishForView>
    {
        public NewOrderDishViewModel()
            : base()
        {
            _selectedDish = new DishForView();

            var dishDataStore = new DishDataStore();
            dishDataStore.RefreshListFromService();
            Dishes = dishDataStore.Items;
        }

        #region Fields  
        private int _itemId;
        private DishForView _selectedDish;

        #endregion Fields

        #region Properties
        public int ItemId
        {
            get => _itemId;
            set => SetProperty(ref _itemId, value);
        }
        public DishForView SelectedDish
        {
            get => _selectedDish;
            set => SetProperty(ref _selectedDish, value);
        }
        public List<DishForView> Dishes { get; }

        #endregion Properties

        public override OrderDishForView SetItem()
        {
            return new OrderDishForView
            {
                Id = 0,
                IsActive = true,
                ModifiedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
                OrderId = ItemId,
                DishId = SelectedDish.Id,
                DishName = SelectedDish.Name
            }.CopyProperties(this);
        }

        public override bool ValidateSave()
        {
            return !String.IsNullOrEmpty(SelectedDish?.Name);
        }
    }
}
