using Microsoft.AspNetCore.Mvc;
using MinhaMissaCore.Model;
using System.ComponentModel.DataAnnotations;

namespace MinhaMissaCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private static List<User> Users = new List<User>
        {
                new User
                {
                    Id = 1,
                    Name = "Felipe Queiroz",
                    Email = "felipequeiroz@minhamissa.com",
                    Password = "12345",
                    Role = "Administrador"
                },
                new User
                {
                    Id = 2,
                    Name = "Gabriel Laroca",
                    Email = "gabriellaroca@minhamissa.com",
                    Password = "12345",
                    Role = "Administrador"
                },
                new User
                {
                    Id = 3,
                    Name = "Walisson Ferraz",
                    Email = "walissonferraz@minhamissa.com",
                    Password = "12345",
                    Role = "Administrador"
                }
        };
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
            var user = Users.Find(u => u.Id == id);

            if (user is null)
            {
                return BadRequest("User not found");
            }

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User user)
        {
            Users.Add(user);
            return Ok(Users);
        }

        [HttpPut]
        public async Task<ActionResult<List<User>>> UpdateUser(User userRequest)
        {
            var userToUpdate = Users.Find(u => u.Id == userRequest.Id);

            if (userToUpdate is null)
            {
                return BadRequest("User not found");
            }

            userToUpdate.Name = userRequest.Name;
            userToUpdate.Email = userRequest.Email;
            userToUpdate.Password = userRequest.Password;
            userToUpdate.Role = userRequest.Role;

            return Ok(Users);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> Delete(int id)
        {
            var userToDelete = Users.Find(u => u.Id == id);

            if (userToDelete is null)
            {
                return BadRequest("User not found");
            }

            Users.Remove(userToDelete);
            return Ok(userToDelete);
        }
    }
}
