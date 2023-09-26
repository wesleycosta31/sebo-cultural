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
    [ApiExplorerSettings(GroupName = "Editoras")]
    public class EditoraService : ControllerBase
    {
        private readonly IRepositorioDeEditoraMySql _editoraRep;

        public EditoraService(IRepositorioDeEditoraMySql editoraRep)
        {
            _editoraRep = editoraRep;
        }

        /// <summary>Retorna a lista completa de editoras.</summary>
        [HttpGet(Name = "FiltrarEditora")]
        public async Task<ActionResult<IEnumerable<Editora>>> FiltrarLivrosAsync()
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Obtem editora por ID.</summary>
        [HttpGet("{id:int}", Name = "FiltrarEditoraById")]
        public async Task<ActionResult<Editora>> FiltrarEditoraByIdAsync(int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Cadastra uma nova editora na plataforma.</summary>
        [HttpPost(Name = "CadastrarEditora")]
        public async Task<ActionResult> CadastrarEditoraAsync([FromBody] EditoraDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Edita as informações de uma editora da plataforma.</summary>
        [HttpPut(Name = "EditarEditora")]
        public async Task<ActionResult<Editora>> EditarEditoraAsync(int id, EditoraDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Remove um autor da plataforma.</summary>
        [HttpDelete("{id:int}", Name = "RemoverEditora")]
        public async Task<ActionResult<Editora>> RemoverEditoraAsync(int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }
    }

}