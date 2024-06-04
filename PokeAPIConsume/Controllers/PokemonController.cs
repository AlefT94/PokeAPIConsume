using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeAPIConsume.Services;

namespace PokeAPIConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly PokemonService _pokemonService;

        public PokemonController(PokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pokemons = await _pokemonService.GetPokemonAsync();
            return Ok(pokemons);
        }
    }
}
