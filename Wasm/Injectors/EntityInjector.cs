using Interfaces;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Injectors
{
    public class EntityInjector : IService
    {
        public IServiceCollection AddServices(IServiceCollection services, IConfiguration configuration = null)
        {
            services.InjectCore();

            return services;
        }
    }
}
