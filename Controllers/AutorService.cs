using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using sebo_cultural.Domínio;
using sebo_cultural.DTOS;

namespace sebo_cultural.Controllers
{
    /// <summary>Controller/Service que gerencia a criação, edição e delete de autores da plataforma.</summary>
    /// 
    [Route("autores")]
    [ApiController]
    public class AutorService : ControllerBase
    {
        private readonly IRepositorioDeAutorMySql _autorRep;

        public AutorService(IRepositorioDeAutorMySql autorRep)
        {
            _autorRep = autorRep;
        }

        /// <summary>Retorna a lista completa de autores.</summary>
        [HttpGet("filtrar-autor")]
        public async Task<ActionResult<ResultadoPaginado<Autor>>> FiltrarAutoresAsync([FromBody] FiltrarAutorDTO autor)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Obtem autor por ID.</summary>
        [HttpGet("{id}/filtrar-autor")]
        public async Task<ActionResult<Autor>> FiltrarAutorByIdAsync([FromRoute] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Cadastra um novo autor na plataforma.</summary>
        [HttpPost("cadastrar-autor")]
        public async Task<ActionResult> CadastrarAutorAsync([FromBody] CadastrarAutorDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Edita as informações de um autor da plataforma.</summary>
        [HttpPut("{id}/editar-autor")]
        public async Task<ActionResult<Autor>> EditarAutorAsync([FromRoute] int id, [FromBody] CadastrarAutorDTO autor)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Remove um autor da plataforma.</summary>
        [HttpDelete("{id}/remover-autor")]
        public async Task<ActionResult<Autor>> RemoverAutorAsync([FromRoute]int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }
    }

}