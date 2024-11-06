using PokeApi.Models;

namespace PokeApi.Services.Interfaces
{
    public interface IEntrenadorService
    {
        IEnumerable<Entrenador> GetAllEntrenadores();
        Entrenador GetEntrenadorById(int id);
        void AddEntrenador(Entrenador entrenador);
        void UpdateEntrenador(Entrenador entrenador);
        void DeleteEntrenador(int id);
    }
}
