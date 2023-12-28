using MongoDB.Driver;

namespace MongoRepositoryPattern.Domain.Context
{
    [Obsolete("Call direct IMongoDataBase")]
    public class MongoDbContext : IMongoDbContext
    {
        public IMongoDatabase Database { get; private set; }

        public MongoDbContext()
        {
            // empty connection string is for local mongo 
            var client = new MongoClient();
            this.Database = client.GetDatabase("TestRepo");
        }
    }
}
