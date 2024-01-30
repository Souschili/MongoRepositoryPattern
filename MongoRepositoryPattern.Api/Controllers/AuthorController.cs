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
        public async Task<ActionResult<IEnumerable<Author>>> Get()
        {
            try
            {
                var authors=await _authorService.GetAllAsync();
                return Ok(authors);
            }
            catch (Exception ex)
            {
                return BadRequest();
                
            }
        }

        // GET api/<AuthorController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var author=await _authorService.GetByIdAsync(id);
                return Ok(author);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
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
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]Author author)
        {
            try
            {
                await _authorService.UpdateAuthorAsync(author);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<AuthorController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                await _authorService.DeleteAuthorAsync(id);
                return Ok();    
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
