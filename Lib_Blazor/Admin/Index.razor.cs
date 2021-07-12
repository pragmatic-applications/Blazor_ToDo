using Domain;

using Microsoft.AspNetCore.Components;

namespace Lib_Blazor.Admin
{
    public partial class Index : ItemBase
    {
        [Parameter] public int Id { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.BannerTitleValue = "Admin - Home";
        }
    }
}
