using Microsoft.AspNetCore.Mvc;
using sebo_cultural.Domínio;

namespace sebo_cultural.Controllers
{
    [ApiController]
    [Route("editoras")]
    [ApiExplorerSettings(GroupName = "Editoras")]

    public class EditoraService : ControllerBase
    {

        [HttpGet(Name = "FiltrarEditora")]
        public async Task<ActionResult<Editora>> FiltrarLivrosAsync([FromBody] Editora editora)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpGet("{id}", Name = "FiltrarEditoraById")]
        public async Task<ActionResult<Editora>> FiltrarEditoraByIdAsync([FromRoute(Name = "id")] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpGet("{id}", Name = "FiltrarLivrosByIdEditora")]
        public async Task<ActionResult<Editora>> FiltrarLivrosByIdEditoraAsync([FromRoute(Name = "id")] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpPost(Name = "CadastrarEditora")]
        public async Task<ActionResult<Editora>> CadastrarEditoraAsync([FromBody] Editora editora)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpPost(Name = "EditarEditora")]
        public async Task<ActionResult<Editora>> EditarEditoraAsync([FromBody] Editora editora)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpPost(Name = "RemoverEditora")]
        public async Task<ActionResult<Editora>> RemoverEditoraAsync([FromBody] Editora editora)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

    }

}