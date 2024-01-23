using Microsoft.Extensions.DependencyInjection;
using MongoRepositoryPattern.ServicesLayer.Contracts;
using MongoRepositoryPattern.ServicesLayer.Services;

namespace MongoRepositoryPattern.ServicesLayer
{
    public static class ServiceLayerRegistration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthorService, AuthorService>();
        }
    }
}
