using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Context;
using api.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharactersController : ControllerBase
    {
        private readonly MyAppDbContext _context = null;
        private readonly ILogger<CharactersController> _logger;

        public CharactersController(ILogger<CharactersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Character> Get()
        {
            return _context.Characters.ToList();
        }
    }
}
