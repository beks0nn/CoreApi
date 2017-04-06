using CoreApi.Models;
using Microsoft.Extensions.DependencyInjection;

namespace CoreApi.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            //Dependency injection "Config" goes here
            services.AddScoped<ITodoRepository, TodoRepository>();


            return services;
        }
    }
}