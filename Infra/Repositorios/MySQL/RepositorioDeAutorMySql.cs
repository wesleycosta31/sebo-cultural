using Microsoft.Extensions.Configuration;
using sebo_cultural.Domínio;

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

	
}