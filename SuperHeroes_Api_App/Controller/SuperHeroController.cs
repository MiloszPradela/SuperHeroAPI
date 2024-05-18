using Microsoft.AspNetCore.Mvc;
using SuperHeroes_Api_App.Interfaces;

namespace SuperHeroes_Api_App.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class SuperHeroController : Controller
    {
        private readonly ISuperHeroInterface _service;

        public SuperHeroController(ISuperHeroInterface service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetSuperHero(int id)
        {
            var superHero = _service.FindHeroByID(id);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (superHero is null)
                return NotFound();
            return Ok(superHero);
        }
    }
    
}
