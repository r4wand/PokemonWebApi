using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PokemonWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class pokedexController : ControllerBase
    {


        private readonly ILogger<pokedexController> _logger;

        public pokedexController(ILogger<pokedexController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "pokedex endpoint";
        }
    }
}
