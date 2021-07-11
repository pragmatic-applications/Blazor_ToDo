using Domain;

using Microsoft.AspNetCore.Components;

namespace Wasm.Admin
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
