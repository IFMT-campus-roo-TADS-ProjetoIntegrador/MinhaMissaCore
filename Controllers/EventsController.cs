using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MinhaMissaCore.Model;

namespace MinhaMissaCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController : ControllerBase
    {
        private static List<Event> Events = new List<Event>();

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
            var eventToGet = await this.dataContext.Events.FindAsync(id);

            if (eventToGet is null)
            {
                return NotFound();
            }

            return Ok(eventToGet);
        }
    }
}
