using Interfaces;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Injectors
{
    public class HostInjector : IService
    {
        public IServiceCollection AddServices(IServiceCollection services, IConfiguration configuration = null)
        {
            services.InjectCore();
            services.AddHostServices(isServerSideBlazor: true);

            return services;
        }
    }
}
