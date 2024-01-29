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

        public async Task AddAuthorAsync(Author author)
        {
            await _authorRepo.CreateAsync(author);
        }

        public async Task DeleteAuthorAsync(string id)
        {
           var result= await _authorRepo.DeleteByIdAsync(id);
            if (!result)
                throw new ArgumentException($"Unable to delete entity with id -> {id}");
        }
    }
}
