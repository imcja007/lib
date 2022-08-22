using LibraryPOC.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryPOC.Controllers
{
    [ApiController]
    [Route("controller")]
    public class AuthorController : Controller
    {
        private readonly IDataRepository<Author> _dataRepository;
        public AuthorController(IDataRepository<Author> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Author> users = _dataRepository.GetAll();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Author Author = _dataRepository.Get(id);
            if (Author == null)
            {
                return NotFound("The author could'nt be found.");
            }
            return Ok(Author);
        }
        [HttpPost]
        [Route("[controller]/Add")]
        public IActionResult Post([FromBody] Author user)
        {
            if (user == null)
            {
                return BadRequest("Employee is null");
            }
            _dataRepository.Add(user);
            return CreatedAtRoute(
            "Get",
            new { AuthorID = user.AuthorID }, user);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Author user)
        {
            if (user == null)
            {
                return BadRequest("Null");
            }
            Author userToUpdate = _dataRepository.Get(id);
            if (userToUpdate == null)
            {
                return NotFound("The Author couldnt be found");
            }
            _dataRepository.Update(userToUpdate, user);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Author user = _dataRepository.Get(id);
            if (user == null)
            {
                return BadRequest("Null");
            }
            _dataRepository.Delete(user);
            return NoContent();
        }
    }
}



