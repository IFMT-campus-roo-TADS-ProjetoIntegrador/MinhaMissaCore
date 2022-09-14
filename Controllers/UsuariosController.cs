using Microsoft.AspNetCore.Mvc;
using MinhaMissaCore.Model;
using System.ComponentModel.DataAnnotations;

namespace MinhaMissaCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetUserAsync()
        {
            var usuarios = new List<Usuarios>
            {
                new Usuarios
                {
                    Id = 1,
                    Nome = "Felipe Queiroz",
                    Email = "felipequeiroz@minhamissa.com",
                    Senha = "12345",
                    Role = "Administrador"
                },
                new Usuarios
                {
                    Id = 2,
                    Nome = "Gabriel Laroca",
                    Email = "gabriellaroca@minhamissa.com",
                    Senha = "12345",
                    Role = "Administrador"
                },
                new Usuarios
                {
                    Id = 3,
                    Nome = "Walisson Ferraz",
                    Email = "walissonferraz@minhamissa.com",
                    Senha = "12345",
                    Role = "Administrador"
                }

            };

            return Ok(usuarios);
        }
    }


}
