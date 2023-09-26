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
    [ApiExplorerSettings(GroupName = "Autores")]
    public class AutorService : ControllerBase
    {
        private readonly IRepositorioDeAutorMySql _autorRep;

        public AutorService(IRepositorioDeAutorMySql autorRep)
        {
            _autorRep = autorRep;
        }

        /// <summary>Retorna a lista completa de autores.</summary>
        [HttpGet(Name = "FiltrarAutor")]
        public async Task<ActionResult<IEnumerable<Produto>>> FiltrarAutoresAsync([FromBody] Autor autor)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Obtem autor por ID.</summary>
        [HttpGet("{id:int}", Name = "FiltrarAutorById")]
        public async Task<ActionResult<Autor>> FiltrarAutorByIdAsync(int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Cadastra um novo autor na plataforma.</summary>
        [HttpPost(Name = "CadastrarAutor")]
        public async Task<ActionResult> CadastrarAutorAsync([FromBody] CadastrarAutorDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Edita as informações de um autor da plataforma.</summary>
        [HttpPut(Name = "EditarAutor")]
        public async Task<ActionResult<Autor>> EditarAutorAsync(int id, CadastrarAutorDTO autor)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Remove um autor da plataforma.</summary>
        [HttpDelete("{id:int}", Name = "RemoverAutor")]
        public async Task<ActionResult<Autor>> RemoverAutorAsync(int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }
    }

}