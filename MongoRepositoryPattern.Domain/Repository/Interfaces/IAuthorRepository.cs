using MongoRepositoryPattern.Domain.Model;

namespace MongoRepositoryPattern.Domain.Repository.Interfaces
{
    public interface IAuthorRepository:IGenericRepository<Author>
    {
        string Test();
    }
}
