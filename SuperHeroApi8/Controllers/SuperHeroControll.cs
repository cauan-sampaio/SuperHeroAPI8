using Microsoft.AspNetCore.Mvc;
using SuperHeroApi8.Entities;

namespace SuperHeroApi8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroControll : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllHeroes()
        {
            var heroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "SpiderMan",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"
                }
            };
            return Ok(heroes);
        }
    }
}