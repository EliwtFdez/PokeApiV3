﻿using Microsoft.AspNetCore.Mvc;
using PokeApi.Context;
using PokeApi.Models;

namespace PokeApi.Controllers
{
    public class PokemonMvcController : Controller
    {
        private readonly AppDbContext _context;

        public PokemonMvcController(AppDbContext context)
        {
            _context = context;
        }

        // GET: PokemonMvcController
        public ActionResult Index()
        {
            var pokemones = _context.Pokemones.ToList();
            return View(pokemones);
        }

        // GET: PokemonMvcController/Details/5
        public ActionResult Details(int id)
        {
            var pokemon = _context.Pokemones.Find(id);
            if (pokemon == null)
                return NotFound();

            return View(pokemon);
        }

        // GET: PokemonMvcController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PokemonMvcController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pokemon pokemon)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Pokemones.Add(pokemon);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(pokemon);
            }
            catch
            {
                return View();
            }
        }

        // GET: PokemonMvcController/Edit/5
        public ActionResult Edit(int id)
        {
            var pokemon = _context.Pokemones.Find(id);
            if (pokemon == null)
                return NotFound();

            return View(pokemon);
        }

        // POST: PokemonMvcController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Pokemon pokemon)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Update(pokemon);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(pokemon);
            }
            catch
            {
                return View();
            }
        }

        // GET: PokemonMvcController/Delete/5
        public ActionResult Delete(int id)
        {
            var pokemon = _context.Pokemones.Find(id);
            if (pokemon == null)
                return NotFound();

            return View(pokemon);
        }

        // POST: PokemonMvcController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var pokemon = _context.Pokemones.Find(id);
                if (pokemon != null)
                {
                    _context.Pokemones.Remove(pokemon);
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
