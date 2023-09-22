using sebo_cultural.DTOS;
namespace sebo_cultural.Domínio;

/// <summary>Classe que representa um autor de um livro da plataforma.</summary>
public class Autor
{
    /// <summary>Código de identificação do autor.</summary>
    public int ID { get; set; }

    /// <summary>Nome completo do autor.</summary>
    public string Nome { get; set; } = null!;

    /// <summary>Ano de nascimento do autor.</summary>
    public int AnoNascimento { get; set; }

    /// <summary>Coleção de livros do Autor.</summary>
    public ICollection<Produto>? Produto { get; set; }

    //Passar uma lista de livros

    /// <summary>Construtor com parâmetros.</summary>
    public Autor(int id, string nome, int anoNascimento, ICollection<Produto>? produto)
    {
        ID = id;
        Nome = nome;
        AnoNascimento = anoNascimento;
        Produto = produto;
    }

    /// <summary>Construtor utilizado no processo de cadastro de um autor.</summary>
    /// <param name="dto">DTO do processo de cadastro de autor.</param>
    public Autor(AutorDTO dto)
    {
        Nome = dto.Nome;
        AnoNascimento = dto.AnoNascimento;
        Produto = dto.Livro;
    }
}