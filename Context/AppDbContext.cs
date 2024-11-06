using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokeApi.Models;

namespace PokeApi.Context
{
    public class AppDbContext : DbContext
    {   
    
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Pokemon> Pokemones { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<PokemonEntrenador> PokemonEntrenadores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definición de clave compuesta para la tabla pokemon_entrenador
            modelBuilder.Entity<PokemonEntrenador>()
                .HasKey(pe => new { pe.IdEntrenador, pe.IdPokemon });
        }

    }
}
