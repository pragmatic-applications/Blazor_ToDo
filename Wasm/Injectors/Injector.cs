using System.Collections.Generic;

using BlazorUI;

using Domain;

using HttpServices;

using Interfaces;

using Lib_BrowserPlatform;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Injectors
{
    public static class Injector
    {
        public static IServiceCollection InjectCore(this IServiceCollection services, IConfiguration configuration = null)
        {
            // S ToDo
            services.AddScoped<ToDoItem>();
            services.AddScoped<List<ToDoItem>>();

            services.AddScoped<ITaskService<ToDoItem>, ToDoItemService>();
            // E ToDO

            services.AddHttpClient<HttpToDoItemService>();
            services.AddHttpClient<ImageUploaderService>();

            services.AddScoped<PagerData>();
            services.AddScoped<List<PagerData>>();
            services.AddScoped<EntityParameter>();
            services.AddScoped<List<EntityParameter>>();

            services.AddScoped<NavigationJSI>(); // Used when JS enabled side nav is enabled.
            services.AddScoped<IBrowserService, BrowserService>();

            return services;
        }
    }
}
