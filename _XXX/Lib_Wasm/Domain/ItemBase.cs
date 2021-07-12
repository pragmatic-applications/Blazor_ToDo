using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using BlazorUI;

using Constants;

using HttpServices;

using Interfaces;

using Lib_BrowserPlatform;

using Microsoft.AspNetCore.Components;

namespace Domain
{
    public class ItemBase : AppComponent<ToDoItem>, IDisposable
    {
        [Inject] public ITaskService<ToDoItem> ToDoItemService { get; set; }
        [Inject] public HttpToDoItemService ItemService { get; set; }

        [Parameter] public ToDoItem ItemParameter { get; set; }
        [Parameter] public List<ToDoItem> ItemsParameter { get; set; }
        [Inject] public ToDoItem Item { get; set; }
        [Inject] public List<ToDoItem> Items { get; set; }

        public string IsDone => this.Item.IsDone ? "Yes" : "No";
        public string EntryId => this.Item.Id < 10 ? $"0{this.Item.Id}" : $"{this.Item.Id}";

        public PagingResponse<ToDoItem> PagingResponse { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            this.ItemSelect = new ItemSelect();
            this.AppNameValue = "Blazor ToDo";

            this.Item = new();

            await this.GetAsync();
        }

        protected override void ClearFields()
        {
            this.Item.Id = 0;
            this.Item.Title = string.Empty;
            this.Item.IsDone = false;
        }

        protected override void Reload() => this.GoToPage(PageRoute.Admin);

        protected override void LoadDataSuccess(PagingResponse<ToDoItem> data)
        {
            this.Items = data.Items;
            this.PagerData = data.PagerData;
            this.IsLoading = false;
            this.IsError = false;
        }

        protected override void LoadDataFail(Exception exception)
        {
            this.Items = null;
            this.IsError = true;
        }

        protected override async Task TryLoadAsync(Action<PagingResponse<ToDoItem>> success, Action<Exception> fail)
        {
            try
            {
                this.PagingResponse = await this.ItemService.GetEntitiesAsync(this.EntityParameter);
                success(this.PagingResponse);
            }
            catch(Exception ex)
            {

                fail(ex);
            }
            finally
            {
                this.IsLoading = false;
            }
        }

        protected override async Task GetAsync() => await this.TryLoadAsync(this.LoadDataSuccess, this.LoadDataFail);
        protected override async Task GetAsync(int id) => this.Item = await this.ItemService.GetEntityByIdAsync(id: id);

        //// Orig
        //protected override async Task InsertAsync()
        //{
        //    await this.ItemService.AddEntityAsync(this.Item);
        //    this.Reload();
        //}

        protected override async Task UpdateAsync()
        {
            await this.ItemService.EditEntityAsync(this.Item.Id, this.Item);
            this.Reload();
        }

        protected override async Task DeleteAsync()
        {
            await this.ItemService.DeleteEntityAsync(this.Item.Id);
            this.Reload();
        }

        protected void AddItem()
        {
            this.ToDoItemService.AddItem(this.Item);
            this.Item = new();
        }

        protected override async Task InsertAsync()
        {
            foreach(var item in this.ToDoItemService.ToDoItems)
            {
                await this.ItemService.AddEntityAsync(item); // Todo: Update to AddRange for collection...
            }

            this.ToDoItemService.Clear();

            this.Reload();
        }

        // Todo: Chech...
        public void Dispose()
        {
            this.ItemSelect = null;
            this.ItemService = null;
            this.Item = null;
            this.Items = null;
            this.PagingResponse = null;
        }
    }
}
