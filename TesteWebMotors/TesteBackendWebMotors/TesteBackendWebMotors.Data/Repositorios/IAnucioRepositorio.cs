using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteBackendWebMotors.Data.Entities;

namespace TesteBackendWebMotors.Data.Repositorios
{
    public interface IAnucioRepositorio
    {
        Task Incluir(Anuncio anuncio);

        Task Atualizar(Anuncio anuncio);

        Task Remover(int id);

        Task<IEnumerable<Anuncio>> ObterTodosOsAnuncios();

        Task <Anuncio> ObterAnuncioPorId(int id);
    }
}
