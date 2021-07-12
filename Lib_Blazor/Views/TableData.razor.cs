using BlazorUI;

using Domain;

using Microsoft.AspNetCore.Components;

namespace Lib_Blazor.Views
{
    public partial class TableData : UIEntityBase
    {
        [Parameter] public ToDoItem EntityParameter { get; set; }
        public string IsDone => this.EntityParameter.IsDone ? "Yes" : "No";
        public string EntryId => this.EntityParameter.Id < 10 ? $"0{this.EntityParameter.Id}" : $"{this.EntityParameter.Id}";
    }
}
