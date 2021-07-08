using Domain;

using BlazorUI;

using Microsoft.AspNetCore.Components;

namespace Wasm.Views
{
    public partial class ItemContainer : UIEntityBase
    {
        [Parameter] public ToDoItem EntityParameter { get; set; }
        public string IsDone => this.EntityParameter.IsDone ? "Yes" : "No";
        public string EntryId => this.EntityParameter.Id < 10 ? $"0{this.EntityParameter.Id}" : $"{this.EntityParameter.Id}";
    }
}
