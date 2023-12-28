using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoRepositoryPattern.Domain.Custom;
using MongoRepositoryPattern.Domain.Model;
using System.Reflection;

namespace MongoRepositoryPattern.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public HomeController() { }

        [HttpGet]
        public IActionResult Get()
        {
            var author = new Author
            {
                Id = 1,
                Name = "Test",
                Description = "Test"
            };
          
            var collectionName = typeof(Author).GetCustomAttribute<CollectionNameAttribute>();
            return Ok(collectionName.Name);
        }
    }
}
