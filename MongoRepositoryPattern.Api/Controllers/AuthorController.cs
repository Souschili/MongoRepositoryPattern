using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoRepositoryPattern.Domain.Model;
using MongoRepositoryPattern.ServicesLayer.Contracts;
using Serilog;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MongoRepositoryPattern.Api.Controllers
{
    [Route("api/[controller]")]  
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
       

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
            
        }

        // GET: api/<AuthorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var result= new string[] { "value1", "value2" };
            Log.Information("Salam");
            Log.Debug("Get value => {@result}", result);
            return result;
        }

        // GET api/<AuthorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AuthorController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Author author)
        {
            try
            {
                await _authorService.AddAuthorAsync(author);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<AuthorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
