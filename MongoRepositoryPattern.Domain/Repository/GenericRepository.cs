using MongoDB.Driver;
using MongoRepositoryPattern.Domain.Custom;
using MongoRepositoryPattern.Domain.Repository.Interfaces;
using System.Reflection;

namespace MongoRepositoryPattern.Domain.Repository
{
    public abstract class GenericRepositoryM<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        private readonly protected IMongoCollection<TEntity> _collection;
        public GenericRepositoryM(IMongoDatabase database)
        {
            string collName = typeof(TEntity).GetCustomAttribute<CollectionNameAttribute>()!.Name;

            if (String.IsNullOrEmpty(collName)) throw new ArgumentNullException($"Collection name unable to read {nameof(TEntity)}");

            this._collection = database.GetCollection<TEntity>(nameof(TEntity));
        }

        public virtual async Task CreateAsync(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);
        }

        public virtual Task<bool> DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
