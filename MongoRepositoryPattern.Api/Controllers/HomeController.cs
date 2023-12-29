using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Get()
        {
            //var author = new Author
            //{
            //    Id = "1",
            //    Name = "Test",
            //    Description = "Test"
            //};

            //var collectionName = typeof(Author).GetCustomAttribute<CollectionNameAttribute>();
            //return Ok(collectionName.Name);
            var t = _repo.Test();
            return Ok(t);
        }
    }
}
