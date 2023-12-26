using Microsoft.Extensions.DependencyInjection;
using MongoRepositoryPattern.Domain.Context;

namespace MongoRepositoryPattern.Domain
{
    public static class ConfigurationDomainServices
    {
        public static void AddMongoDbContext(this IServiceCollection service)
        {
            service.AddSingleton<IMongoDbContext, MongoDbContext>();
        }
    }
}
