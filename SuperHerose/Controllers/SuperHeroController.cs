using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHerose.Models;

namespace SuperHerose.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllHerose()
        {
            var herose = new List<SuperHero> {
                new SuperHero
                {
                    Id = 1,
                    Name = "Spiderman",
                    FirstName = "Piter",
                    LastName = "Parker",
                    Place = "New York City"
                }
            };

            return Ok(herose);
        }
    }
}
