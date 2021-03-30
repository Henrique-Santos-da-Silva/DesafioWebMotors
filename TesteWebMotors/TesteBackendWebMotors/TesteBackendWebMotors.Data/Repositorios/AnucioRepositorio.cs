using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackendWebMotors.Data.DataContext;
using TesteBackendWebMotors.Data.Entities;

namespace TesteBackendWebMotors.Data.Repositorios
{
    public class AnucioRepositorio : IAnucioRepositorio
    {
        private readonly DatabaseContext _context;

        public AnucioRepositorio(DatabaseContext context)
        {
            _context = context;
        }
        
        public async Task Atualizar(Anuncio anuncio)
        {
            _context.Entry(anuncio).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }

        public async Task Incluir(Anuncio anuncio)
        {
            if (anuncio == null)
                throw new ArgumentNullException("Os dados do anuncio estão nulo");


            _context.Anuncios.Add(anuncio);
            await _context.SaveChangesAsync();
        }
            

        public async Task<Anuncio> ObterAnuncioPorId(int id)
        {
            var anuncio = await _context.Anuncios.FindAsync(id);

            if (anuncio == null)
                throw new ArgumentNullException("O Anuncio com o id buscado não existe");

            return anuncio;


        }

        public async Task<IEnumerable<Anuncio>> ObterTodosOsAnuncios() =>
            await _context.Anuncios.ToListAsync();

        public async Task Remover(int id)
        {
            var anuncioBuscado = await _context.Anuncios.FindAsync(id);

            if (anuncioBuscado != null)
            {
                _context.Anuncios.Remove(anuncioBuscado);
                await _context.SaveChangesAsync();
            }
                
            
        }
    }
}
