namespace MongoRepositoryPattern.Domain.Repository.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task CreateAsync(T entity);
        Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<bool> DeleteAsync(T entity);
        Task<bool> UpdateAsync(T entity);

    }
}
