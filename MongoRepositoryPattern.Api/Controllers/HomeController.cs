using Microsoft.AspNetCore.Mvc;
using MongoRepositoryPattern.Domain.Model;
using MongoRepositoryPattern.Domain.Repository.Interfaces;

namespace MongoRepositoryPattern.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IAuthorRepository _repo;
        public HomeController(IAuthorRepository repository)
        {
            this._repo = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var author = new Author
            {
                Id = "1",
                Name = "Test",
                Description = "Test"
            };
            await _repo.CreateAsync(author);
            //var collectionName = typeof(Author).GetCustomAttribute<CollectionNameAttribute>();
            //return Ok(collectionName.Name);

            return Ok("Added");
        }
    }
}
