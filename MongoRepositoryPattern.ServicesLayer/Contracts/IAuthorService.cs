using MongoRepositoryPattern.Domain.Model;

namespace MongoRepositoryPattern.ServicesLayer.Contracts
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAllAsync ();
        Task<Author> GetByIdAsync(string id);
        Task AddAuthorAsync(Author author);
        Task UpdateAuthorAsync(Author author);
        Task DeleteAuthorAsync(string id);
        Task<List<Author>?> GetByParamNameAsync(string paramName,string value);

    }
}
