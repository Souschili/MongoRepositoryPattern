using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using MongoRepositoryPattern.Domain.Context;

namespace MongoRepositoryPattern.Domain
{
    public static class ConfigurationDomainServices
    {
        
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
