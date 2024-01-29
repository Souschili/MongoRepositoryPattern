using MongoDB.Driver;
using MongoRepositoryPattern.Domain.Model;
using MongoRepositoryPattern.Domain.Repository.Interfaces;

namespace MongoRepositoryPattern.Domain.Repository
{
    public class AuthorRepository : GenericRepository<Author>,IAuthorRepository
    {
        public AuthorRepository(IMongoDatabase database) : base(database) { }

        /// <summary>
        /// delete single document from collection by Id
        /// </summary>
        /// <param name="id">Document Id</param>
        /// <returns>True if document delete  or false if not</returns>
        public async Task<bool> DeleteByIdAsync(string id)
        {
           var result= await _collection.DeleteOneAsync(x=>x.Id==id);
            return result.DeletedCount > 0;
        }

    }
}
