using MongoDB.Driver;

namespace MongoRepositoryPattern.Domain.Context
{
    public interface IMongoDbContext
    {
        IMongoDatabase Database { get; }
    }
}