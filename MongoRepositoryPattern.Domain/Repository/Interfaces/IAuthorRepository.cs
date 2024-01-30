using MongoRepositoryPattern.Domain.Model;

namespace MongoRepositoryPattern.Domain.Repository.Interfaces
{
    public interface IAuthorRepository:IGenericRepository<Author>
    {
        Task<bool> DeleteByIdAsync(string id);
        Task<List<Author>?> GetByParamNameAsync(string paramname,object value);
    }
}
