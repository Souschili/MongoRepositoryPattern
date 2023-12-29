using MongoDB.Driver;
using MongoRepositoryPattern.Domain.Custom;
using MongoRepositoryPattern.Domain.Model.Base;
using MongoRepositoryPattern.Domain.Repository.Interfaces;
using System.Reflection;

namespace MongoRepositoryPattern.Domain.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly protected IMongoCollection<TEntity> _collection;
        public GenericRepository(IMongoDatabase database)
        {
            string collName = typeof(TEntity).GetCustomAttribute<CollectionNameAttribute>()!.Name;

            if (String.IsNullOrEmpty(collName)) throw new ArgumentNullException($"Collection name unable to read {nameof(TEntity)}");

            this._collection = database.GetCollection<TEntity>(collName);
        }

        public virtual async Task CreateAsync(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);
        }

        public virtual async Task<bool> DeleteAsync(FilterDefinition<TEntity> filter)
        {
            var deleteresult = await _collection.DeleteOneAsync(filter);
            return deleteresult.DeletedCount > 0;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public virtual async Task<TEntity> GetAsync(string id)
        {
            FilterDefinition<TEntity> filter = Builders<TEntity>.Filter.Eq(x => x.Id, id);
            return await _collection.Find(filter).FirstOrDefaultAsync();
        }

        public virtual async Task<bool> UpdateAsync(FilterDefinition<TEntity> filter, UpdateDefinition<TEntity> updateFilter)
        {
            var rezult = await _collection.UpdateOneAsync(filter, updateFilter);
            return rezult.ModifiedCount > 0;
        }
    }
}
