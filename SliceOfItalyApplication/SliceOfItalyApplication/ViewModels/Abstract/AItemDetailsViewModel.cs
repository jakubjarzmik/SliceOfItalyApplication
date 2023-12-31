﻿using System;
using System.Diagnostics;
using SliceOfItalyApplication.Services.Abstract;
using Xamarin.Forms;

namespace SliceOfItalyApplication.ViewModels.Abstract
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public abstract class AItemDetailsViewModel<T> : BaseViewModel
    {
        protected AItemDetailsViewModel()
        {
            CancelCommand = new Command(OnCancel);
            DeleteCommand = new Command(OnDelete);
        }
        public IDataStore<T> DataStore => DependencyService.Get<IDataStore<T>>();

        public Command DeleteCommand { get; }
        public Command CancelCommand { get; }
        public abstract void LoadProperties(T item);
        private async void OnDelete()
        {
            await DataStore.DeleteItemAsync(_itemId);
            await Shell.Current.GoToAsync("..");
        }
        private async void OnCancel()
        {
            await Shell.Current.GoToAsync("..");
        }


        private int _itemId;
        public int ItemId
        {
            get
            {
                return _itemId;
            }
            set
            {
                _itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(int itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                LoadProperties(item);
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
