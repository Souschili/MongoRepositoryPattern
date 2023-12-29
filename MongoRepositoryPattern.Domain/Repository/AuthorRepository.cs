using MongoDB.Driver;
using MongoRepositoryPattern.Domain.Model;

namespace MongoRepositoryPattern.Domain.Repository
{
    public class AuthorRepository : GenericRepository<Author>
    {
        public AuthorRepository(IMongoDatabase database) : base(database) { }
       
    }
}
