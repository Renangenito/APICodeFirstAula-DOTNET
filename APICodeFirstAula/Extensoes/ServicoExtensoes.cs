using APICodigoFirstAula.Context;
using Microsoft.EntityFrameworkCore;

namespace APICodeFirstAula.Extensoes
{
    public static class ServicoExtensoes
    {

        public static void CinfigurarServicos(this IServiceCollection services)
        {
            string connectionstring = "data source=localhost,1433;user id=sa;password=senha@1234xxxy;initial catalog=BancoFilmes;";

            services.AddDbContext<ControlerFilmesDBContext>(item => item.UseSqlServer(connectionstring));
        }

    }
}
