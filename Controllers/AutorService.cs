using Microsoft.AspNetCore.Mvc;
using sebo_cultural.Domínio;

namespace sebo_cultural.Controllers
{
    [ApiController]
    [Route("autores")]
    [ApiExplorerSettings(GroupName = "Autores")]

    public class AutorService : ControllerBase
    {
        [HttpGet(Name = "FiltrarAutor")]
        public async Task<ActionResult<Produto>> FiltrarAutoresAsync([FromBody] Autor autor)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpGet("{id}", Name = "FiltrarAutorById")]
        public async Task<ActionResult<Autor>> FiltrarAutorByIdAsync([FromRoute(Name = "id")] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpGet("{id}", Name = "FiltrarLivrosByIdAutor")]
        public async Task<ActionResult<Autor>> FiltrarLivrosByIdAutorAsync([FromRoute(Name = "id")] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpPost(Name = "CadastrarAutor")]
        public async Task<ActionResult<Autor>> CadastrarAutorAsync([FromBody] Autor autor)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpPost(Name = "EditarAutor")]
        public async Task<ActionResult<Autor>> EditarAutorAsync([FromBody] Autor autor)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpPost(Name = "RemoverAutor")]
        public async Task<ActionResult<Autor>> RemoverAutorAsync([FromBody] Autor autor)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

    }

}