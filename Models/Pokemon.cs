namespace PokeApi.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoPrimario { get; set; }
        public int? TipoSecundario { get; set; }

        public Tipo TipoPrimarioNavigation { get; set; }
        public Tipo TipoSecundarioNavigation { get; set; }
    }
}
