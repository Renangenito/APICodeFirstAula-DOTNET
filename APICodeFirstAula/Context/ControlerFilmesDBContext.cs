using APICodeFirstAula.Context;
using Microsoft.EntityFrameworkCore;

namespace APICodigoFirstAula.Context
{
    public class ControlerFilmesDBContext : DbContext
    {

        public ControlerFilmesDBContext(DbContextOptions<ControlerFilmesDBContext> options) : base(options)
        {

        }

        public DbSet<Filme> Filmes { get; set; }

       
    }
}
