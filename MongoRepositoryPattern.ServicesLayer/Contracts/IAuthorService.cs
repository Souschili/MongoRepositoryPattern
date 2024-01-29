using MongoRepositoryPattern.Domain.Model;

namespace MongoRepositoryPattern.ServicesLayer.Contracts
{
    public interface IAuthorService
    {
        Task AddAuthorAsync(Author author);
        Task DeleteAuthorAsync(string id);

    }
}
