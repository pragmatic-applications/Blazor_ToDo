using Domain;

namespace Wasm
{
    public partial class About : ItemBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.BannerTitleValue = "About";
        }
    }
}
