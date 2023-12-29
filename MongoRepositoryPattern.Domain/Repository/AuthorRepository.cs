using MongoDB.Driver;
using MongoRepositoryPattern.Domain.Model;
using MongoRepositoryPattern.Domain.Repository.Interfaces;

namespace MongoRepositoryPattern.Domain.Repository
{
    public class AuthorRepository : GenericRepository<Author>,IAuthorRepository
    {
        public AuthorRepository(IMongoDatabase database) : base(database) { }

        public string Test()
        {
            return "additional method";
        }
    }
}
