using Database;

using Interfaces;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Injectors
{
    public class DbContextInjector : IService
    {
        public IServiceCollection AddServices(IServiceCollection services, IConfiguration configuration = null)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=SQLite.db"));

            return services;
        }
    }
}
