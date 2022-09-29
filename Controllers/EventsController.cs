using Microsoft.AspNetCore.Mvc;
using MinhaMissaCore.Model;

namespace MinhaMissaCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController : ControllerBase
    {
        private List<Event> Events = new List<Event>
        {
            new Event
                {
                    Id = 1,
                    Name = "Missa de Natal",
                    Description = "Missa de Natal, que celebra o nascimento de Jesus.",
                    StartDate = DateTime.Now,
                    LastDate = DateTime.Now.AddDays(90),
                    Local = "Paróquia Nossa Senhora Aparecida",
                    Places = 400,
                    Active = true
                },
                new Event
                {
                    Id = 2,
                    Name = "Missa de Pascoa",
                    Description = "Missa de Pascoa, que celebra a ressurreição de Jesus.",
                    StartDate = DateTime.Now,
                    LastDate = DateTime.Now.AddDays(120),
                    Local = "Paróquia Nossa Senhora Aparecida",
                    Places = 300,
                    Active = true
                }
        };
        public DataContext dataContext;
        public EventsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Event>>> Get()
        {
            return Ok(Events);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Event>>> GetById(int id)
        {
            var eventToGet = Events.Find(e => e.Id == id);
            
            if (eventToGet is null)
            {
                return BadRequest("User not found");
            }

            return Ok(eventToGet);
        }
    }
}
