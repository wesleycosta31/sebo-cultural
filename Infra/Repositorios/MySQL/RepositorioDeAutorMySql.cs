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


        public async Task<ResultadoPaginado<Autor>> ListarAutorAsync(string? searchExpression, uint pageIndex = 1, uint pageSize = 50)
        {
            await using var con = new MySqlConnection(_conString);
            await using var cmd = new MySqlCommand(string.Empty, con);

            // Define o offset para a paginação.
            uint offset = (pageIndex - 1) * pageSize;

            await Task.Yield();
            throw new NotImplementedException();
        }


        /// <summary>Obtem as informações de um autor no repositório com base em código de identificação.</summary>
        /// <param name="iDAutor">Endereço de e-mail do usuário que será utilizado como filtro.</param>
        /// <returns>Entidade que representa o autor encontrado.</returns>
        public async Task<Autor> ObterAutorByIDAsync(ushort iDAutor)
        {
            await using var con = new MySqlConnection(_conString);
            await using var cmd = new MySqlCommand(string.Empty, con);

            var cmdStr = @"select
                            atr.idAutor,
                            atr.Nome,
                            atr.DataNascimento,
                            atr.Nacionalidade,
                        from autor atr
                        where
                            atr.idAutor = @iDAutor;";

            cmd.Parameters.AddWithValue("iDautor", iDAutor);

            Autor autor = null!;

            await con.OpenAsync();
            cmd.CommandText = cmdStr;

            await cmd.ExecuteReaderAsync();

            return autor;
        }
    }
}