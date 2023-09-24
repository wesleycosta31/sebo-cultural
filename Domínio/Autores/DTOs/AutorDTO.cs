using Relier.Security.Domain.Users;
using sebo_cultural.Domínio;

namespace sebo_cultural.DTOS;

/// <summary>DTO que representa um autor de um livro da plataforma.</summary>
public class AutorDTO
{
    /// <summary>Nome completo do autor.</summary>
    public string Nome { get; set; } = null!;

    /// <summary>Ano de nascimento do autor.</summary>
    public int AnoNascimento { get; set; }

    /// <summary>Tipo do produto.</summary>
    public ProdutoTipo? ProdutoTipo { get; set; }

    /// <summary>Código de identificação do produto.</summary>
    public int? IDProduto { get; set; }

}