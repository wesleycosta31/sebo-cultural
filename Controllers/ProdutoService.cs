using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using sebo_cultural.Domínio;
using sebo_cultural.DTOS;

namespace sebo_cultural.Controllers
{
    /// <summary>Controller/Service que gerencia a criação, edição e delete de um produto da plataforma.</summary>
    /// 
    [Route("Produtos")]
    [ApiController]
    public class ProdutoService : ControllerBase
    {
        private readonly IRepositorioDeProdutoMySql _produtoRep;

        public ProdutoService(IRepositorioDeProdutoMySql produtoRep)
        {
            _produtoRep = produtoRep;
        }

        /// <summary>Retorna a lista completa de produtos da plataforma.</summary>
        [HttpGet("filtrar-produto")]
        public async Task<ActionResult<Produto>> FiltrarProdutosAsync([FromBody] Produto livro)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Retorna produto por ID.</summary>
        [HttpGet("{id}/filtrar-produto")]
        public async Task<ActionResult<Produto>> FiltrarProdutoByIdAsync([FromRoute] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Retorna produto pelo ID do autor.</summary>
        [HttpGet("{id}/filtrar-produtos-by-autor")]
        public async Task<ActionResult<IEnumerable<Produto>>> FiltrarProdutosByIdAutorAsync([FromRoute] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Retorna produto pelo ID da editora.</summary>
        [HttpGet("{id}/filtrar-produtos-by-editora")]
        public async Task<ActionResult<IEnumerable<Produto>>> FiltrarProdutosByIdEditoraAsync([FromRoute] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Cadastra um novo livro na plataforma.</summary>
        [HttpPost("cadastrar-livro")]
        public async Task<ActionResult> CadastrarLivroAsync([FromBody] CadastraLivroDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Cadastra um novo album de música na plataforma.</summary>
        [HttpPost("cadastrar-album")]
        public async Task<ActionResult> CadastrarAlbumAsync([FromBody] CadastraAlbumMusicalDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Edita as informações de um livro da plataforma.</summary>
        [HttpPut("{id}/editar-livro")]
        public async Task<ActionResult<Produto>> EditarProdutoLivroAsync([FromRoute] int id, [FromBody] CadastraLivroDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Edita as informações de um livro da plataforma.</summary>
        [HttpPut("{id}/editar-album")]
        public async Task<ActionResult<Produto>> EditarProdutoAlbumDeMusicaAsync([FromRoute] int id, [FromBody] CadastraAlbumMusicalDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpPost("{id}/deletar-produto")]
        public async Task<ActionResult<Produto>> RemoverProdutoAsync([FromRoute] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }
    }

}