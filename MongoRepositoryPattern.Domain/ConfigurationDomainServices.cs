using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using MongoRepositoryPattern.Domain.Context;
using MongoRepositoryPattern.Domain.Repository;
using MongoRepositoryPattern.Domain.Repository.Interfaces;

namespace MongoRepositoryPattern.Domain
{
    public static class ConfigurationDomainServices
    {
        public static void AddRepository(this IServiceCollection services)
        {
            // don't work if genericrepo abstract
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IAuthorRepository, AuthorRepository>();

        }

        public static void AddMongoDbContext(this IServiceCollection service)
        {
            service.AddSingleton<IMongoDbContext, MongoDbContext>();
        }

        static public void AddMongoDataBase(this IServiceCollection service)
        {
            service.AddSingleton(cfg =>
            {
                var client = new MongoClient();
                return client.GetDatabase("TestRepo");

            });
        }
    }
}
