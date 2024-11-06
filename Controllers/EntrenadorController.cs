using Microsoft.AspNetCore.Mvc;
using PokeApi.Context;
using PokeApi.Models;

namespace PokeApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EntrenadorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EntrenadorController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Entrenador
        [HttpGet]
        public ActionResult<IEnumerable<Entrenador>> GetEntrenadores()
        {
            return _context.Entrenadores.ToList();
        }

        // GET: api/Entrenador/5
        [HttpGet("{id}")]
        public ActionResult<Entrenador> GetEntrenador(int idEntrenador)
        {
            var entrenador = _context.Entrenadores.Find(idEntrenador);
            if (entrenador == null)

                return NotFound();

            return entrenador;
        }

        // POST: api/Entrenador
        [HttpPost]
        public ActionResult<Entrenador> CreateEntrenador(Entrenador entrenador)
        {
            if (ModelState.IsValid)
            {
                _context.Entrenadores.Add(entrenador);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetEntrenador), new { id = entrenador.IdEntrenador }, entrenador);
            }
            return BadRequest(ModelState);
        }

        // PUT: api/Entrenador/5
        [HttpPut("{id}")]
        public IActionResult EditEntrenador(int idEntrenador, Entrenador entrenador)
        {
            if (idEntrenador != entrenador.IdEntrenador)
                return BadRequest();

            if (ModelState.IsValid)
            {
                _context.Update(entrenador);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        // DELETE: api/Entrenador/5
        [HttpDelete("{idEntrenador}")]
        public IActionResult DeleteEntrenador(int idEntrenador)
        {
            var entrenador = _context.Entrenadores.Find(idEntrenador);
            if (entrenador == null)
                return NotFound();

            _context.Entrenadores.Remove(entrenador);
            _context.SaveChanges();
            return NoContent();
        }
    }


}
