using MongoDB.Driver;
using MongoRepositoryPattern.Domain.Repository.Interfaces;

namespace MongoRepositoryPattern.Domain.Repository
{
    public class GenericRepositoryM<TEntity> : IGenericRepository<TEntity> where TEntity : class,new()
    {
        private readonly protected IMongoCollection<TEntity> _collection;
        public GenericRepositoryM(IMongoDatabase database)
        {
            this._collection = database.GetCollection<TEntity>(nameof(TEntity));
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);
        }

        public Task<bool> DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
