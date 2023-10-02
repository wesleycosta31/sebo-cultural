namespace sebo_cultural.Domínio;

/// <summary>Utilizado para armazenar a paginação e os resultados da paginação de uma consulta.</summary>
public class ResultadoPaginado<T>
{
    /// <summary>Total de registros retornados no banco de dados.</summary>
    public long TotalLinhas { get; }

    /// <summary>Total de páginas que a consulta retornou com os filtros atuais possui.</summary>
    public uint Paginas { get; }

    /// <summary>Página atual da consulta.</summary>
    public uint IndiceDaPagina { get; }

    /// <summary>Dados retornados da consulta ao banco de dados.</summary>
    public IEnumerable<T> Dado { get; }

    /// <summary>Construtor com parâmetros para inicialização.</summary>
    /// <param name="totalLinhas">Total de registros retornados no banco de dados.</param>
    /// <param name="paginas">Total de páginas que a consulta retornou com os filtros atuais possui.</param>
    /// <param name="indiceDaPagina">Página atual da consulta.</param>
    /// <param name="dado">Dados retornados da consulta ao banco de dados.</param>
    public ResultadoPaginado(long totalLinhas, uint paginas, uint indiceDaPagina, IEnumerable<T> dado)
    {
        TotalLinhas = totalLinhas;
        Paginas = paginas;
        IndiceDaPagina = indiceDaPagina;
        Dado = dado;
    }
}