using PokeApi.Models;
using PokeApi.Services.Interfaces;

namespace PokeApi.Services
{
    public class EntrenadorService : IEntrenadorService
    {
        private readonly IEntrenadorService _entrenadorRepository;

        public EntrenadorService(IEntrenadorService entrenadorRepository)
        {
            _entrenadorRepository = entrenadorRepository;
        }

        public IEnumerable<Entrenador> GetAllEntrenadores()
        {
            return _entrenadorRepository.GetAllEntrenadores();
        }

        public Entrenador GetEntrenadorById(int id)
        {
            return _entrenadorRepository.GetEntrenadorById(id);
        }

        public void AddEntrenador(Entrenador entrenador)
        {
            _entrenadorRepository.AddEntrenador(entrenador);
        }

        public void UpdateEntrenador(Entrenador entrenador)
        {
            _entrenadorRepository.UpdateEntrenador(entrenador);
        }

        public void DeleteEntrenador(int id)
        {
            _entrenadorRepository.DeleteEntrenador(id);
        }
    }

}
