using Microsoft.AspNetCore.Mvc;
using PokeApi.Context;
using PokeApi.Models;

namespace PokeApi.Controllers
{
    public class EntrenadorController : Controller
    {
        private readonly AppDbContext _context;

        public EntrenadorController(AppDbContext context)
        {
            _context = context;
        }

        // GET: EntrenadorMvcController
        public ActionResult Index()
        {
            var entrenadores = _context.Entrenadores.ToList();
            return View(entrenadores);
        }

        // GET: EntrenadorMvcController/Details/5
        public ActionResult Details(int id)
        {
            var entrenador = _context.Entrenadores.Find(id);
            if (entrenador == null)
                return NotFound();

            return View(entrenador);
        }

        // GET: EntrenadorMvcController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EntrenadorMvcController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Entrenador entrenador)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Entrenadores.Add(entrenador);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(entrenador);
            }
            catch
            {
                return View();
            }
        }

        // GET: EntrenadorMvcController/Edit/5
        public ActionResult Edit(int id)
        {
            var entrenador = _context.Entrenadores.Find(id);
            if (entrenador == null)
                return NotFound();

            return View(entrenador);
        }

        // POST: EntrenadorMvcController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Entrenador entrenador)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Update(entrenador);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(entrenador);
            }
            catch
            {
                return View();
            }
        }

        // GET: EntrenadorMvcController/Delete/5
        public ActionResult Delete(int id)
        {
            var entrenador = _context.Entrenadores.Find(id);
            if (entrenador == null)
                return NotFound();

            return View(entrenador);
        }

        // POST: EntrenadorMvcController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var entrenador = _context.Entrenadores.Find(id);
                if (entrenador != null)
                {
                    _context.Entrenadores.Remove(entrenador);
                    _context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
