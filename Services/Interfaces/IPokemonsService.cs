using PokeApi.Models;

namespace PokeApi.Services.Interfaces
{
    public interface IPokemonsService
    {
        IEnumerable<Pokemon> GetAllPokemones();
        Pokemon GetPokemonById(int id);
        void AddPokemon(Pokemon pokemon);
        void UpdatePokemon(Pokemon pokemon);
        void DeletePokemon(int id);
    }
}
