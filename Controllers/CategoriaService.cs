using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using sebo_cultural.Domínio;
using sebo_cultural.DTOS;

namespace sebo_cultural.Controllers
{
    /// <summary>Controller/Service que gerencia a criação, edição e delete de Categorias da plataforma.</summary>
    /// 
    [Route("categorias")]
    [ApiController]
    public class CategoriaService : ControllerBase
    {
        private readonly IRepositorioDeCategoriaMySql _categoriaRep;

        public CategoriaService(IRepositorioDeCategoriaMySql categoriaRep)
        {
            _categoriaRep = categoriaRep;
        }

        /// <summary>Retorna a lista completa de categorias.</summary>
        [HttpGet("filtrar-categoria")]
        public async Task<ActionResult<IEnumerable<Categoria>>> FiltrarLivrosAsync()
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Obtem categoria por ID.</summary>
        [HttpGet("{id}/filtrar-categoria")]
        public async Task<ActionResult<Categoria>> FiltrarCategoriaByIdAsync([FromRoute] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Cadastra uma nova categoria na plataforma.</summary>
        [HttpPost("cadastrar-categoria")]
        public async Task<ActionResult> CadastrarCategoriaAsync([FromBody] CategoriaDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Edita as informações de uma categoria da plataforma.</summary>
        [HttpPut("{id}/editar-categoria")]
        public async Task<ActionResult<Categoria>> EditarCategoriaAsync([FromRoute] int id, CategoriaDTO dto)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        /// <summary>Remove um autor da plataforma.</summary>
        [HttpDelete("{id}/remover-categoria")]
        public async Task<ActionResult<Categoria>> RemoverCategoriaAsync([FromRoute] int id)
        {
            await Task.Yield();
            throw new NotImplementedException();
        }
    }

}