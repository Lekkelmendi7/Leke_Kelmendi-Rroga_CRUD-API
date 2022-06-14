using Microsoft.AspNetCore.Mvc;

namespace Leke_Kelmendi_Rroga_CRUD_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RrogaController : ControllerBase
    {
        
        private readonly DataContext context;

        public RrogaController(DataContext context) {
            this.context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Rroga>>> Get()
        {
            return Ok(await context.Rrogat.ToListAsync());
        }
        [HttpGet("{ID}")]
        public async Task<ActionResult<Rroga>> Get(int ID)
        {
            var rrogat = await context.Rrogat.FindAsync(ID);
            if (rrogat == null)
                return BadRequest("Rroga e puntorit nuk u gjet!");
            return Ok(rrogat);
        }

        [HttpPost]
        public async Task<ActionResult<List<Rroga>>> AddHero(Rroga rrogat)
        {
            context.Rrogat.Add(rrogat);
            await context.SaveChangesAsync();
            return Ok(await context.Rrogat.ToListAsync());

        }

        [HttpPut]

        public async Task<ActionResult<List<Rroga>>> UpdateRroga(Rroga request)
        {
            var dbrroga = await context.Rrogat.FindAsync(request.ID_Puntori);
            if (dbrroga == null)
                return BadRequest("Rroga nuk u gjet!");

            dbrroga.Emri_Puntorit = request.Emri_Puntorit;
            dbrroga.Mbiemri_Puntorit = request.Mbiemri_Puntorit;
            dbrroga.Kompania = request.Kompania;
            dbrroga.Pozita_Punes = request.Pozita_Punes;
            dbrroga.Rroga_Puntorit = request.Rroga_Puntorit;
            await context.SaveChangesAsync();

            return Ok(await context.Rrogat.ToListAsync());
        }

        [HttpDelete("{ID}")]
        
        public async Task<ActionResult<List<Rroga>>> Delete(int ID)
        {
            var dbrroga = await context.Rrogat.FindAsync(ID);
            if (dbrroga == null)
                return BadRequest("Rroga e puntorit nuk u gjet!");

            context.Rrogat.Remove(dbrroga);
            await context.SaveChangesAsync();

           
            return Ok(await context.Rrogat.ToListAsync());
        }


    }
    }

