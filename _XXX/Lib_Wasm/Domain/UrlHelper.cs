using Constants;

using Lib_Wasm;

namespace Domain
{
    public class UrlHelper
    {
        public static string GetImagePath() => DeployedState.IsDeployed ? HttpConstant.Api_Image_Path_Deployed : HttpConstant.Api_Image_Path;
    }
}
