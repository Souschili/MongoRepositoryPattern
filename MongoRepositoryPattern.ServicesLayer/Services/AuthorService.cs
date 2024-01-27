using MongoRepositoryPattern.Domain.Model;
using MongoRepositoryPattern.Domain.Repository.Interfaces;
using MongoRepositoryPattern.ServicesLayer.Contracts;

namespace MongoRepositoryPattern.ServicesLayer.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepo;

        public AuthorService(IAuthorRepository authorRepo)
        {
            _authorRepo = authorRepo;
        }

        public Task AddAuthorAsync(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
