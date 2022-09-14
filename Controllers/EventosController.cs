using Microsoft.AspNetCore.Mvc;
using MinhaMissaCore.Model;

namespace MinhaMissaCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventosController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var eventos = new List<Eventos>
            {
                new Eventos
                {
                    Id = 1,
                    Nome = "Missa de Natal",
                    Descricao = "Missa de Natal, que celebra o nascimento de Jesus.",
                    DataAbertura = DateTime.Now,
                    DataEncerramento = DateTime.Now.AddDays(90),
                    Local = "Paróquia Nossa Senhora Aparecida",
                    Vagas = 400,
                    Ativo = true
                },
                new Eventos
                {
                    Id = 2,
                    Nome = "Missa de Pascoa",
                    Descricao = "Missa de Pascoa, que celebra a ressurreição de Jesus.",
                    DataAbertura = DateTime.Now,
                    DataEncerramento = DateTime.Now.AddDays(120),
                    Local = "Paróquia Nossa Senhora Aparecida",
                    Vagas = 300,
                    Ativo = true
                }
            };

            return Ok(eventos);
        }
    }
}
