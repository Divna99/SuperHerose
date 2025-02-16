using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHerose.Data;
using SuperHerose.Models;

namespace SuperHerose.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;

        public SuperHeroController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHerose()
        {
            var herose = await _context.SuperHeroes.ToListAsync();

            return Ok(herose);
        }
    }
}
