using PokeAPIConsume.Models;
using System.Text.Json;

namespace PokeAPIConsume.Services
{
    public class PokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PokemonResponse> GetPokemonAsync()
        {
            var response = await _httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon?limit=10");
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var pokemonResponse = JsonSerializer.Deserialize<PokemonResponse>(responseContent);

            return pokemonResponse;
        }
    }
}
