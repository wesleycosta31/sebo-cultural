using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using sebo_cultural.Domínio;

namespace sebo_cultural.Infra.Repositorios.MySQL
{
    public class RepositorioDeAutorMySql : IRepositorioDeAutorMySql
    {
        /// <summary>String para conexão com a base de dados.</param>
        private readonly string _conString;

        /// <summary>Construtor com parâmetros para inicialização.</summary>
        /// <param name="config">Objeto que contém as configurações da aplicação.</param>
        public RepositorioDeAutorMySql(IConfiguration config)
        {
            _conString = config.GetConnectionString(nameof(IRepositorioDeAutorMySql));
        }


        public async Task<ResultadoPaginado<Autor>> ListarAsync(string? searchExpression, uint pageIndex = 1, uint pageSize = 50)
        {
            await using var con = new MySqlConnection(_conString);
            await using var cmd = new MySqlCommand(string.Empty, con);

            // Define o offset para a paginação.
            uint offset = (pageIndex - 1) * pageSize;
            
            await Task.Yield();
            throw new NotImplementedException();
        }

    }
}