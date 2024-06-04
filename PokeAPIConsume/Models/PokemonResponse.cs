namespace PokeAPIConsume.Models
{
    public class PokemonResponse
    {
        public int count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
        public ICollection<Pokemon> results { get; set; }
    }
}
