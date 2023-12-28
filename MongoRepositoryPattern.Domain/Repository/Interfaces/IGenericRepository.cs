namespace MongoRepositoryPattern.Domain.Repository.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class, new()
    {
        Task CreateAsync(TEntity entity);
        Task<TEntity> GetAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<bool> DeleteAsync(TEntity entity);
        Task<bool> UpdateAsync(TEntity entity);

    }
}
