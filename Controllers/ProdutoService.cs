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
    [ApiExplorerSettings(GroupName = "Produtos")]

    public class ProdutoService : ControllerBase
    {
        private readonly MySqlConnection _connection;

        public ProdutoService(MySqlConnection connection)
        {
            _connection = connection;
        }

        /// <summary>Retorna a lista completa de produtos da plataforma.</summary>
        [HttpGet(Name = "FiltrarProduto")]
        public async Task<ActionResult<Produto>> FiltrarProdutosAsync([FromBody] Produto ivro)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Retorna produto por ID.</summary>
        [HttpGet("{id:int}", Name = "FiltrarProdutoById")]
        public async Task<ActionResult<Produto>> FiltrarProdutoByIdAsync(int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Retorna produto pelo ID do autor.</summary>
        [HttpGet("by-autor", Name = "FiltrarProdutosByIdAutor")]
        public async Task<ActionResult<IEnumerable<Produto>>> FiltrarProdutosByIdAutorAsync(int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Retorna produto pelo ID da editora.</summary>
        [HttpGet("by-editora", Name = "FiltrarProdutosByIdEditora")]
        public async Task<ActionResult<IEnumerable<Produto>>> FiltrarProdutosByIdEditoraAsync(int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }
        
        /// <summary>Cadastra um novo livro na plataforma.</summary>
        [HttpPost(Name = "CadastrarLivro")]
        public async Task<ActionResult> CadastrarLivroAsync([FromBody] CadastraLivroDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Cadastra um novo album de música na plataforma.</summary>
        [HttpPost(Name = "CadastrarAlbumDeMusica")]
        public async Task<ActionResult> CadastrarAlbumAsync([FromBody] CadastraAlbumMusicalDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Edita as informações de um livro da plataforma.</summary>
        [HttpPut(Name = "EditarLivro")]
        public async Task<ActionResult<Produto>> EditarProdutoLivroAsync(int id, CadastraLivroDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Edita as informações de um livro da plataforma.</summary>
        [HttpPut(Name = "EditarAlbumMusical")]
        public async Task<ActionResult<Produto>> EditarProdutoAlbumDeMusicaAsync(int id, CadastraAlbumMusicalDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        [HttpPost(Name = "RemoverProduto")]
        public async Task<ActionResult<Produto>> RemoverProdutoAsync(int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }
    }


}