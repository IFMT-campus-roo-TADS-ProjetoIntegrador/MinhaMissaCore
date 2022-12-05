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

        [HttpPost]
        public async Task<ActionResult<List<Event>>> AddEvent(Event newEvent)
        {
            await this.dataContext.AddAsync(newEvent);
            await this.dataContext.SaveChangesAsync();

            return Ok(newEvent);
        }

        [HttpPut]
        public async Task<ActionResult<List<Event>>> UpdateEvent (Event eventRequest)
        {
            var eventToUpdate = await this.dataContext.Events.FindAsync(eventRequest);

            if (eventToUpdate == null)
            {
                return NotFound();
            }

            eventToUpdate.Name = eventRequest.Name;
            eventToUpdate.Location = eventRequest.Location;
            eventToUpdate.Description = eventRequest.Description;
            eventToUpdate.StartDate = eventRequest.StartDate;
            eventToUpdate.Duration = eventRequest.Duration;
            eventToUpdate.Seats = eventRequest.Seats;
            eventToUpdate.Instituition = eventRequest.Instituition;


            await this.dataContext.SaveChangesAsync();
            return Ok(Events);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Event>>> Delete(int id)
        {
            var eventToDelete = await this.dataContext.Events.FindAsync(id);

            if (eventToDelete == null)
            {
                return NotFound();
            }

            this.dataContext.Events.Remove(eventToDelete);
            await this.dataContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
