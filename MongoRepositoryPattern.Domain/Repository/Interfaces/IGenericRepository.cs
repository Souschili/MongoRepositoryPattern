using MongoDB.Driver;
using MongoRepositoryPattern.Domain.Model.Base;

namespace MongoRepositoryPattern.Domain.Repository.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity, new()
    {
        Task CreateAsync(TEntity entity);
        Task<TEntity> GetAsync(string id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<bool> DeleteAsync(string id);
        Task<bool> UpdateAsync(FilterDefinition<TEntity> filter, UpdateDefinition<TEntity> updateFilter);

    }
}
