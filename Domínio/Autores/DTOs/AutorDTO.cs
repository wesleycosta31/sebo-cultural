using sebo_cultural.Domínio;

namespace sebo_cultural.DTOS;

/// <summary>DTO que representa um autor de um livro da plataforma.</summary>
public class AutorDTO
{
    /// <summary>Nome completo do autor.</summary>
    public string Nome { get; set; } = null!;

    /// <summary>Ano de nascimento do autor.</summary>
    public int AnoNascimento { get; set; }

    /// <summary>Coleção de livros do Autor.</summary>
    public ICollection<Produto>? Livro { get; set; }

}