using BlazorUI;

using Domain;

namespace Wasm.Admin
{
    public partial class Create : ItemBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.FormTitle = "Add Entry";
            this.FormMode = FormMode.Create;
            this.ButtonText = "Save";
            this.BannerTitleValue = "Admin - Create";
        }
    }
}
