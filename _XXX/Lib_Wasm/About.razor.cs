using Domain;

namespace Lib_Wasm
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
