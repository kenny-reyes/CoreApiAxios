using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharactersController : ControllerBase
    {
        private readonly ILogger<CharactersController> _logger;

        public CharactersController(ILogger<CharactersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Character> Get()
        {
            return new List<Character>{new Character
            {
                gender = "male",
                id = 1,
                image = "https://rickandmortyapi.…/character/avatar/1.jpeg",
                name = "Rick",
                species = "human"
            }};
        }
    }
}
