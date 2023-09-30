using sebo_cultural.DTOS;
namespace sebo_cultural.Domínio;

/// <summary>Classe que representa uma editora de um ou mais livros da plataforma.</summary>
public class Editora
{
    /// <summary>Código de identificação do autor.</summary>
    public int ID { get; set; }

    /// <summary>Nome da editora.</summary>
    public string NomeEditora { get; set; } = null!;


    /// <summary>Construtor com parâmetros.</summary>
    public Editora(int id, string nomeEditora, ICollection<Produto>? livro)
    {
        ID = id;
        NomeEditora = nomeEditora;
    }

    /// <summary>Construtor utilizado no processo de cadastro de uma nova editora.</summary>
    /// <param name="dto">DTO do processo de cadastro de uma nova editora.</param>
    public Editora(EditoraDTO dto)
    {
        NomeEditora = dto.NomeEditora;
    }
}