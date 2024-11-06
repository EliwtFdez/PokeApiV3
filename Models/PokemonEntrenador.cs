namespace PokeApi.Models
{
    public class PokemonEntrenador
    {
        public int IdEntrenador { get; set; }
        public int IdPokemon { get; set; }
        public int NivelPokemon { get; set; }
        public int Hp { get; set; }
        public int HpMax { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public int AtaqueEspecial { get; set; }
        public int DefensaEspecial { get; set; }
        public int Velocidad { get; set; }

        public Entrenador Entrenador { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
