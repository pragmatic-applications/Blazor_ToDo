using System.Collections.Generic;

using Domain;

using BlazorUI;

using Microsoft.AspNetCore.Components;

namespace Lib_Wasm.Views
{
    public partial class IndexContainer : HomeBase
    {
        [Parameter] public List<ToDoItem> EntitiesParameter { get; set; }
    }
}
