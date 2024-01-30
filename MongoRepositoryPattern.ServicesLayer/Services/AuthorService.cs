using MongoDB.Driver;
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

        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            return await _authorRepo.GetAllAsync();
        }

        public async Task<Author> GetByIdAsync(string id)
        {
            var author=await _authorRepo.GetAsync(id);
            if (author == null) 
                throw new ArgumentException($"Author with id {id} Not Found");
            return author;
        }

        public async Task<List<Author>?> GetByParamNameAsync(string paramName, object value)
        {
            var authors = await _authorRepo.GetByParamNameAsync(paramName, value);
            return authors;
        }

        public async Task UpdateAuthorAsync(Author author)
        {
            FilterDefinition<Author> filter=Builders<Author>.Filter.Eq(x=> x.Id, author.Id);
            UpdateDefinition<Author> updFilter = Builders<Author>.Update.
                Set(x => x.FirstName, author.FirstName)
                .Set(x => x.LastName, author.LastName);
            var result=await _authorRepo.UpdateAsync(filter,updFilter);
            if (!result) throw new ArgumentException($"Unable to update document with Id - > {author.Id}");
        }
    }
}
