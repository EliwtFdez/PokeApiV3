using PokeApi.Models;
using PokeApi.Services.Interfaces;
using System.Collections.Generic;

namespace PokeApi.Services
{
   
    public class PokemonsService : IPokemonsService
    {
        private readonly IPokemonsService _pokemonRepositorio;

        public PokemonsService(IPokemonsService pokemonRepositorio)
        {
            _pokemonRepositorio = pokemonRepositorio;
        }

        public IEnumerable<Pokemon> GetAllPokemones()
        {
            return _pokemonRepositorio.GetAllPokemones();
        }

        public Pokemon GetPokemonById(int id)
        {
            return _pokemonRepositorio.GetPokemonById(id);
        }

        public void AddPokemon(Pokemon pokemon)
        {
            _pokemonRepositorio.AddPokemon(pokemon);
        }

        public void UpdatePokemon(Pokemon pokemon)
        {
            _pokemonRepositorio.UpdatePokemon(pokemon);
        }

        public void DeletePokemon(int id)
        {
            _pokemonRepositorio.DeletePokemon(id);
        }
    }
}
