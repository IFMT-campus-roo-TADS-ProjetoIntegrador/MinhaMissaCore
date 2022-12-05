using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MinhaMissaCore.Model;

namespace MinhaMissaCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstituitionController : ControllerBase
    {
        private static List<Instituition> Instituitions = new List<Instituition>();

        public DataContext dataContext;
        public InstituitionController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Instituition>>> Get()
        {
            return Ok(Instituitions);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Instituition>>> GetById(int id)
        {
            var instituitions = await this.dataContext.Intituitions.FindAsync(id);

            if (instituitions is null)
            {
                return NotFound();
            }

            return Ok(Instituitions);
        }

        [HttpPost]
        public async Task<ActionResult<List<Instituition>>> AddInstituition(Instituition instituition)
        {
            await this.dataContext.AddAsync(instituition);
            await this.dataContext.SaveChangesAsync();

            return Ok(Instituitions);
        }

        [HttpPut]
        public async Task<ActionResult<List<Instituition>>> UpdateInstituition(Instituition instituition)
        {
            var instituitionToUpdate = await this.dataContext.Intituitions.FindAsync(instituition);

            if (instituitionToUpdate == null)
            {
                return NotFound();
            }

            instituitionToUpdate.Name = instituition.Name;
            instituitionToUpdate.Address = instituition.Address;

            await this.dataContext.SaveChangesAsync();
            return Ok(Instituitions);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Instituition>>> Delete(int id)
        {
            var instituitionToDelete = await this.dataContext.Intituitions.FindAsync(id);

            if (instituitionToDelete == null)
            {
                return NotFound();
            }

            this.dataContext.Intituitions.Remove(instituitionToDelete);
            await this.dataContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
