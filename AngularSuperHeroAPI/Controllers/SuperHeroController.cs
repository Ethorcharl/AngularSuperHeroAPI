using AngularSuperHeroAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularSuperHeroAPI.Controllers
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
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes() 
        {

            //return new List<SuperHero> {
            //    new SuperHero
            //    {
            //        Name ="Spider Man",
            //        FirstName = "Peter",
            //        LastName = "Parker",
            //        Place = "New York City"
            //    }
            //};
            return Ok(await _context.SuperHeroes.ToListAsync());
        }
    }
}
