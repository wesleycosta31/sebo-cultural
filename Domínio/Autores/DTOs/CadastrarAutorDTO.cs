using sebo_cultural.Domínio;
using sebo_cultural.Enums;

namespace sebo_cultural.DTOS;

/// <summary>DTO que representa um autor de um livro da plataforma.</summary>
public class CadastrarAutorDTO
{
    /// <summary>Nome completo do autor.</summary>
    public string Nome { get; set; } = null!;

    /// <summary>Ano de nascimento do autor.</summary>
    public DateOnly? DataNascimento { get; set; }

    /// <summary>Tipo do produto.</summary>
    public ProdutoTipo? ProdutoTipo { get; set; }

    /// <summary>Código de identificação do produto.</summary>
    public int? IDProduto { get; set; }

}