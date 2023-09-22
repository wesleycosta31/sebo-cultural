using Microsoft.AspNetCore.Mvc;
using sebo_cultural.Domínio;

namespace sebo_cultural.Controllers
{
    [ApiController]
    [Route("Produtos")]
    [ApiExplorerSettings(GroupName = "Produtos")]

    public class ProdutoService : ControllerBase
    {

        [HttpGet(Name = "FiltrarProduto")]
        public async Task<ActionResult<Produto>> FiltrarProdutosAsync([FromBody] Produto ivro)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpGet("{id}", Name = "FiltrarProdutoById")]
        public async Task<ActionResult<Produto>> FiltrarProdutoByIdAsync([FromRoute(Name = "id")] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpGet("{id}", Name = "FiltrarProdutosByIdAutor")]
        public async Task<ActionResult<Produto>> FiltrarProdutosByIdAutorAsync([FromRoute(Name = "id")] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpPost(Name = "CadastrarProduto")]
        public async Task<ActionResult<Produto>> CadastrarProdutoAsync([FromBody] Produto Produto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpPost(Name = "EditarProduto")]
        public async Task<ActionResult<Produto>> EditarProdutoAsync([FromBody] Produto Produto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpPost(Name = "RemoverProduto")]
        public async Task<ActionResult<Produto>> RemoverProdutoAsync([FromBody] Produto Produto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        //Verificar as alterações de Livro para Produto e a criação da nova classe de categorias.

    }


}