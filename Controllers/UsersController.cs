using Microsoft.AspNetCore.Mvc;
using MinhaMissaCore.Model;

namespace MinhaMissaCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private static List<User> Users = new List<User>();

        public DataContext dataContext;

        public UsersController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return Ok(Users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<User>>> GetById(int id)
        {
            var user = await this.dataContext.Users.FindAsync(id);

            if (user is null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User user)
        {
            await this.dataContext.AddAsync(user);
            await this.dataContext.SaveChangesAsync();

            return Ok(Users);
        }

        [HttpPut]
        public async Task<ActionResult<List<User>>> UpdateUser(User userRequest)
        {
            var userToUpdate = await this.dataContext.Users.FindAsync(userRequest);

            if (userToUpdate == null)
            {
                return NotFound();
            }

            userToUpdate.Username = userRequest.Username;
            userToUpdate.PasswordHash = userRequest.PasswordHash;
            userToUpdate.PasswordSalt = userRequest.PasswordSalt;
            userToUpdate.EventsRegistered = userRequest.EventsRegistered;
            userToUpdate.Role = userRequest.Role;
            userToUpdate.Active = userRequest.Active;

            await this.dataContext.SaveChangesAsync();
            return Ok(Users);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> Delete(int id)
        {
            var userToDelete = await this.dataContext.Users.FindAsync(id);

            if (userToDelete == null)
            {
                return NotFound();
            }

            this.dataContext.Users.Remove(userToDelete);
            await this.dataContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
