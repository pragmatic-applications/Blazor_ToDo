using Domain;

using Interfaces;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Repositories;

namespace Injectors
{
    public class RepositoryInjector : IService
    {
        public IServiceCollection AddServices(IServiceCollection services, IConfiguration configuration = null)
        {
            services.AddScoped<IToDoItemRepository, ToDoItemRepository>();
            services.AddScoped<IRepository<ToDoItem>, Repository<ToDoItem>>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
