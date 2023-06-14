﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SliceOfItalyApplication.Services.Abstract
{
    public abstract class AListDataStore<T> : ADataStore, IDataStore<T> where T : class
    {
        public List<T> Items = new List<T>();
        public AListDataStore()
            : base()
        {
            RefreshListFromService();
        }

        public async Task<bool> AddItemAsync(T item)
        {
            Items.Add(await AddItemToService(item));
            return await Task.FromResult(true);
        }
        public abstract Task<T> Find(T item);
        public abstract Task<T> Find(int id);
        public abstract Task RefreshListFromService();
        public abstract Task<bool> DeleteItemFromService(T item);
        public abstract Task<bool> UpdateItemInService(T item);
        public abstract Task<T> AddItemToService(T item);

        public async Task<bool> UpdateItemAsync(T item)
        {
            await UpdateItemInService(item);
            await RefreshListFromService();
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = await Find(id);
            Items.Remove(oldItem);
            await DeleteItemFromService(oldItem);
            await RefreshListFromService();
            return await Task.FromResult(true);
        }

        public async Task<T> GetItemAsync(int id)
        {
            return await Task.FromResult(await Find(id));
        }

        public async Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false)
        {
            await RefreshListFromService();
            return await Task.FromResult(Items);
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }
    }

}
