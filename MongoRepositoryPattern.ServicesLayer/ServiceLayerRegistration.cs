using Microsoft.Extensions.DependencyInjection;
using MongoRepositoryPattern.ServicesLayer.Contracts;
using MongoRepositoryPattern.ServicesLayer.Services;

namespace MongoRepositoryPattern.ServicesLayer
{
    static class ServiceLayerRegistration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthorService, AuthorService>();
        }
    }
}
