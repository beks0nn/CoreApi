using CoreApi.Models;
using CoreApi.Models.Repo;
using CoreApi.Models.Repo.Interface;
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