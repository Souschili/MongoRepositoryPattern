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

        /// <summary>
        /// Get list of document by special param and value
        /// </summary>
        /// <param name="paramname">Param name</param>
        /// <param name="value">Value of param</param>
        /// <returns>List<Authors> as result or null</returns>
        public async Task<List<Author>?> GetByParamNameAsync(string paramname, string value)
        {
            FilterDefinition<Author> filter = Builders<Author>.Filter.Eq(paramname,value);
            var result=await _collection.Find(filter).ToListAsync();
            return result;
        }
    }
}
