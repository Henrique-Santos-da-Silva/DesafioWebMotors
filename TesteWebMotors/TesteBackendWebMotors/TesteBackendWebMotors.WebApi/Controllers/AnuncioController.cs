using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteBackendWebMotors.Data.Entities;
using TesteBackendWebMotors.Data.Repositorios;

namespace TesteBackendWebMotors.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnuncioController : Controller
    {
        private readonly IAnucioRepositorio _repositorio;

        public AnuncioController(IAnucioRepositorio repositorio)
        {

            _repositorio = repositorio;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Anuncio>>> BuscarTodosAnuncios()
        {
            var anuncios = await _repositorio.ObterTodosOsAnuncios();
            return Ok(anuncios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Anuncio>> BuscarPorId(int id)
        {
            var anuncioEspecifico = await _repositorio.ObterAnuncioPorId(id);

            if (anuncioEspecifico == null)
                return NotFound(new { messageError = "Anuncio não encontrado" , anuncioEspecifico});

            return Ok(anuncioEspecifico);
        }

        [HttpPost]
        public async Task<ActionResult<Anuncio>> CadastrarAnuncio([FromBody] Anuncio anuncio)
        {
            try
            {
                await _repositorio.Incluir(anuncio);

                return CreatedAtAction(nameof(BuscarTodosAnuncios), new { id = anuncio.Id }, anuncio);
            }
            catch (Exception)
            {

                return BadRequest(new { messageError = "Ocorreu um erro inesperado" });
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> AtualizarAnuncio(int id, Anuncio anuncio)
        {

            if (id != anuncio.Id)
            {
                return NotFound(new { messageError = "Anuncio não encontrado", anuncio });
            }

            await _repositorio.Atualizar(anuncio);

            return Ok(anuncio);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoverAnuncio(int id)
        {
            try
            {
                await _repositorio.Remover(id);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest(new { messageError = "Ocorreu um erro inesperado" });
            }
        }


    }
}
