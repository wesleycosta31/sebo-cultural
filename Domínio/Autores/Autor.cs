using sebo_cultural.DTOS;
using sebo_cultural.Enums;
namespace sebo_cultural.Domínio;

/// <summary>Classe que representa um autor de um livro da plataforma.</summary>
public class Autor
{
    /// <summary>Código de identificação do autor.</summary>
    public ushort ID { get; set; }

    /// <summary>Nome completo do autor.</summary>
    public string Nome { get; set; } = null!;

    /// <summary>Ano de nascimento do autor.</summary>
    public DateTime? DataNascimento { get; set; }

    /// <summary>Nacionalidade do autor.</summary>
    public string Nacionalidade { get; set; } = null!;

    /// <summary>Construtor com parâmetros.</summary>
    public Autor(ushort id, string nome, DateTime anoNascimento, string nacionalidade)
    {
        ID = id;
        Nome = nome;
        DataNascimento = anoNascimento;
        Nacionalidade = nacionalidade;
    }

    /// <summary>Construtor utilizado no processo de cadastro de um autor.</summary>
    /// <param name="dto">DTO do processo de cadastro de autor.</param>
    public Autor(CadastrarAutorDTO dto)
    {
        Nome = dto.Nome;
        DataNascimento = dto.DataNascimento;
        Nacionalidade = dto.Nacionalidade;  
    }
}