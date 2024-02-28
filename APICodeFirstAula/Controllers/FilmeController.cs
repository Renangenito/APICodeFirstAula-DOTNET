using APICodeFirstAula.Context;
using APICodigoFirstAula.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICodeFirstAula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private readonly ControlerFilmesDBContext _context;

        public FilmeController(ControlerFilmesDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void Post([FromBody] Filme filme)
        {
            _context.Filmes.Add(filme);
            _context.SaveChanges(); 
        }

        [HttpGet]
        public async Task<List<Filme>> Get()
        {
            return _context.Filmes.ToList();
        }
    }
}
