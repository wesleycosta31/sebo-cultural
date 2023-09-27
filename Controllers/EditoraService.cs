using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using sebo_cultural.Domínio;
using sebo_cultural.DTOS;

namespace sebo_cultural.Controllers
{
    /// <summary>Controller/Service que gerencia a criação, edição e delete de editoras da plataforma.</summary>
    /// 
    [Route("editoras")]
    [ApiController]
    public class EditoraService : ControllerBase
    {
        private readonly IRepositorioDeEditoraMySql _editoraRep;

        public EditoraService(IRepositorioDeEditoraMySql editoraRep)
        {
            _editoraRep = editoraRep;
        }

        /// <summary>Retorna a lista completa de editoras.</summary>
        [HttpGet("filtrar-editora")]
        public async Task<ActionResult<IEnumerable<Editora>>> FiltrarLivrosAsync()
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Obtem editora por ID.</summary>
        [HttpGet("{id}/filtrar-editora")]
        public async Task<ActionResult<Editora>> FiltrarEditoraByIdAsync([FromRoute] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Cadastra uma nova editora na plataforma.</summary>
        [HttpPost("cadastrar-editora")]
        public async Task<ActionResult> CadastrarEditoraAsync([FromBody] EditoraDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Edita as informações de uma editora da plataforma.</summary>
        [HttpPut("{id}/editar-editora")]
        public async Task<ActionResult<Editora>> EditarEditoraAsync([FromRoute] int id, EditoraDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Remove um autor da plataforma.</summary>
        [HttpDelete("{id}/remover-editora")]
        public async Task<ActionResult<Editora>> RemoverEditoraAsync([FromRoute] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }
    }

}