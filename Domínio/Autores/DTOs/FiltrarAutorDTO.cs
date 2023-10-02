using sebo_cultural.Domínio;
using sebo_cultural.Enums;

namespace sebo_cultural.DTOS;

/// <summary>DTO que representa um autor de um livro da plataforma.</summary>
public class FiltrarAutorDTO
{
    /// <summary>Busca por texto no nome do autor.</summary>
    public string? SearchExpression { get; set; }

    /// <summary>Página atual da busca.</summary>
    public uint PageIndex { get; set; } = 1;

    /// <summary>Quantidade de registros retornados por página.</summary>
    public uint PageSize { get; set; } = 50;

}