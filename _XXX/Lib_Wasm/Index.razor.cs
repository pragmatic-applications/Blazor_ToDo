using Domain;

using Interfaces;

using Microsoft.AspNetCore.Components;

namespace Lib_Wasm
{
    public partial class Index : ItemBase
    {
        [Inject] public IBrowserService BrowserService { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.BannerTitleValue = "Home";
        }
    }
}
